using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using ChuDe3_ThaoTacTapTin.Models;
using ChuDe3_ThaoTacTapTin.Storage;

namespace ChuDe3_ThaoTacTapTin.BLL
{
    public enum FileFormatType
    {
        TXT,
        XML,
        JSON
    }

    /// <summary>
    /// Lớp Quản lý sinh viên (StudentManager) thực hiện toàn bộ nghiệp vụ quản lý,
    /// xác thực, tìm kiếm và đọc/ghi file.
    /// </summary>
    public class QuanLySinhVien
    {
        public List<SinhVien> DanhSach { get; set; }
        public string DuongDanHienTai { get; set; }
        public FileFormatType DinhDangHienTai { get; set; }

        public QuanLySinhVien()
        {
            DanhSach = new List<SinhVien>();
            DinhDangHienTai = FileFormatType.JSON;
        }

        public IStudentStorage LayStorage(FileFormatType format)
        {
            switch (format)
            {
                case FileFormatType.TXT:
                    return new TxtStudentStorage();
                case FileFormatType.XML:
                    return new XmlStudentStorage();
                case FileFormatType.JSON:
                default:
                    return new JsonStudentStorage();
            }
        }

        public static FileFormatType XacDinhDinhDangTuDuongDan(string path)
        {
            string ext = Path.GetExtension(path).ToLower();
            if (ext == ".txt") return FileFormatType.TXT;
            if (ext == ".xml") return FileFormatType.XML;
            return FileFormatType.JSON;
        }

        public void DocTuFile(string filePath, FileFormatType format)
        {
            var storage = LayStorage(format);
            DanhSach = storage.Load(filePath);
            DuongDanHienTai = filePath;
            DinhDangHienTai = format;
        }

        public void GhiRaFile(string filePath, FileFormatType format)
        {
            var storage = LayStorage(format);
            storage.Save(filePath, DanhSach);
            DuongDanHienTai = filePath;
            DinhDangHienTai = format;
        }

        public void LuuTuDong()
        {
            if (!string.IsNullOrEmpty(DuongDanHienTai))
            {
                GhiRaFile(DuongDanHienTai, DinhDangHienTai);
            }
        }

        #region Nghiệp vụ kiểm tra hợp lệ MSSV theo Lớp (AABBCCC)
        /// <summary>
        /// Tính 2 chữ số năm nhập học AA dựa vào tên Lớp.
        /// Ví dụ CTK43 -> 19, CTK44 -> 20, CTK45 -> 21, CTK46 -> 22, CTK47 -> 23, CTK48 -> 24.
        /// </summary>
        public static string LayHaiSoCuoiNamNhapHoc(string lop)
        {
            if (string.IsNullOrWhiteSpace(lop)) return "";

            // Trích xuất số khóa từ tên lớp dạng CTK48, CTK48B...
            var match = Regex.Match(lop.ToUpper(), @"CTK(\d+)");
            if (match.Success)
            {
                int khoa = int.Parse(match.Groups[1].Value);
                int namNhapHoc = 1976 + khoa;
                return (namNhapHoc % 100).ToString("D2");
            }

            // Nếu lớp có định dạng số năm trực tiếp (ví dụ 2024 -> 24)
            var match2 = Regex.Match(lop, @"(\d{2})");
            if (match2.Success)
            {
                return match2.Groups[1].Value;
            }

            return "";
        }

        /// <summary>
        /// Kiểm tra MSSV gồm 7 chữ số dạng AABBCCC:
        /// - AA: 2 số cuối năm nhập học của sinh viên (dựa theo lớp)
        /// - BB = 10
        /// - CCC: 3 chữ số bất kỳ
        /// </summary>
        public bool KiemTraHopLeMSSV(string mssv, string lop, bool isThemMoi, out string thongBaoLoi)
        {
            thongBaoLoi = "";
            if (string.IsNullOrWhiteSpace(mssv))
            {
                thongBaoLoi = "Mã số sinh viên không được để trống!";
                return false;
            }

            mssv = mssv.Trim();
            if (mssv.Length != 7 || !Regex.IsMatch(mssv, @"^\d{7}$"))
            {
                thongBaoLoi = "MSSV phải gồm đúng 7 ký tự số!";
                return false;
            }

            string expectedAA = LayHaiSoCuoiNamNhapHoc(lop);
            string aa = mssv.Substring(0, 2);
            string bb = mssv.Substring(2, 2);

            if (bb != "10")
            {
                thongBaoLoi = string.Format("MSSV phải có dạng AABBCCC với BB = 10 (Hiện tại BB = '{0}')!", bb);
                return false;
            }

            if (!string.IsNullOrEmpty(expectedAA) && aa != expectedAA)
            {
                thongBaoLoi = string.Format("Với lớp '{0}', năm nhập học có 2 số cuối là '{1}'. Do đó MSSV phải bắt đầu bằng '{1}10' thay vì '{2}'!",
                    lop, expectedAA, aa + bb);
                return false;
            }

            if (isThemMoi)
            {
                if (DanhSach.Any(s => s.MSSV.Equals(mssv, StringComparison.OrdinalIgnoreCase)))
                {
                    thongBaoLoi = string.Format("MSSV '{0}' đã tồn tại trong danh sách! Không được trùng MSSV.", mssv);
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Kiểm tra toàn bộ thông tin nhập liệu của sinh viên
        /// </summary>
        public bool KiemTraDayDuThongTin(SinhVien sv, bool isThemMoi, out string thongBaoLoi)
        {
            thongBaoLoi = "";
            if (sv == null)
            {
                thongBaoLoi = "Dữ liệu sinh viên không hợp lệ!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(sv.Lop))
            {
                thongBaoLoi = "Vui lòng chọn Lớp cho sinh viên!";
                return false;
            }

            if (!KiemTraHopLeMSSV(sv.MSSV, sv.Lop, isThemMoi, out thongBaoLoi))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(sv.HoLot))
            {
                thongBaoLoi = "Họ và tên lót không được để trống!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(sv.Ten))
            {
                thongBaoLoi = "Tên sinh viên không được để trống!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(sv.SoCMND) || sv.SoCMND.Length != 9 || !Regex.IsMatch(sv.SoCMND, @"^\d{9}$"))
            {
                thongBaoLoi = "Số CMND phải gồm đúng 9 chữ số!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(sv.SoDT) || sv.SoDT.Length != 10 || !Regex.IsMatch(sv.SoDT, @"^\d{10}$"))
            {
                thongBaoLoi = "Số điện thoại phải gồm đúng 10 chữ số!";
                return false;
            }

            if (string.IsNullOrWhiteSpace(sv.DiaChi))
            {
                thongBaoLoi = "Địa chỉ liên lạc không được để trống!";
                return false;
            }

            if (sv.MonHoc == null || sv.MonHoc.Count == 0)
            {
                thongBaoLoi = "Vui lòng chọn ít nhất 1 môn học đăng ký!";
                return false;
            }

            return true;
        }
        #endregion

        #region Các chức năng Thêm, Cập nhật, Xóa
        public bool ThemSinhVien(SinhVien sv, out string thongBaoLoi)
        {
            if (!KiemTraDayDuThongTin(sv, true, out thongBaoLoi))
            {
                return false;
            }

            DanhSach.Add(sv);
            LuuTuDong();
            return true;
        }

        public bool CapNhatSinhVien(SinhVien sv, out string thongBaoLoi)
        {
            if (!KiemTraDayDuThongTin(sv, false, out thongBaoLoi))
            {
                return false;
            }

            int index = DanhSach.FindIndex(s => s.MSSV.Equals(sv.MSSV, StringComparison.OrdinalIgnoreCase));
            if (index < 0)
            {
                thongBaoLoi = string.Format("Không tìm thấy sinh viên có MSSV '{0}' để cập nhật!", sv.MSSV);
                return false;
            }

            DanhSach[index] = sv;
            LuuTuDong();
            return true;
        }

        public bool XoaSinhVien(string mssv)
        {
            int removed = DanhSach.RemoveAll(s => s.MSSV.Equals(mssv, StringComparison.OrdinalIgnoreCase));
            if (removed > 0)
            {
                LuuTuDong();
                return true;
            }
            return false;
        }

        public int XoaDanhSachSinhVien(IEnumerable<string> danhSachMSSV)
        {
            var set = new HashSet<string>(danhSachMSSV, StringComparer.OrdinalIgnoreCase);
            int count = DanhSach.RemoveAll(s => set.Contains(s.MSSV));
            if (count > 0)
            {
                LuuTuDong();
            }
            return count;
        }

        public SinhVien TimTheoMSSV(string mssv)
        {
            if (string.IsNullOrWhiteSpace(mssv)) return null;
            return DanhSach.FirstOrDefault(s => s.MSSV.Equals(mssv.Trim(), StringComparison.OrdinalIgnoreCase));
        }
        #endregion

        #region Các chức năng Tìm kiếm (Đơn điều kiện & Đa điều kiện)
        public List<SinhVien> TimKiemTheoMSSV(string mssv)
        {
            if (string.IsNullOrWhiteSpace(mssv)) return new List<SinhVien>(DanhSach);
            return DanhSach.Where(s => s.MSSV.IndexOf(mssv.Trim(), StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }

        public List<SinhVien> TimKiemTheoTen(string ten)
        {
            if (string.IsNullOrWhiteSpace(ten)) return new List<SinhVien>(DanhSach);
            ten = ten.Trim();
            return DanhSach.Where(s => s.Ten.IndexOf(ten, StringComparison.OrdinalIgnoreCase) >= 0 
                                    || s.HoLot.IndexOf(ten, StringComparison.OrdinalIgnoreCase) >= 0
                                    || s.HoVaTen.IndexOf(ten, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }

        public List<SinhVien> TimKiemTheoLop(string lop)
        {
            if (string.IsNullOrWhiteSpace(lop)) return new List<SinhVien>(DanhSach);
            return DanhSach.Where(s => s.Lop.Equals(lop.Trim(), StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<SinhVien> TimKiemDaDieuKien(string mssv, string hoTen, string lop, bool? gioiTinh, 
                                                string soCMND, string soDT, string diaChi, string monHoc)
        {
            IEnumerable<SinhVien> query = DanhSach;

            if (!string.IsNullOrWhiteSpace(mssv))
            {
                query = query.Where(s => s.MSSV.IndexOf(mssv.Trim(), StringComparison.OrdinalIgnoreCase) >= 0);
            }

            if (!string.IsNullOrWhiteSpace(hoTen))
            {
                string ht = hoTen.Trim();
                query = query.Where(s => s.HoVaTen.IndexOf(ht, StringComparison.OrdinalIgnoreCase) >= 0
                                      || s.Ten.IndexOf(ht, StringComparison.OrdinalIgnoreCase) >= 0
                                      || s.HoLot.IndexOf(ht, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            if (!string.IsNullOrWhiteSpace(lop) && lop != "Tất cả")
            {
                query = query.Where(s => s.Lop.Equals(lop.Trim(), StringComparison.OrdinalIgnoreCase));
            }

            if (gioiTinh.HasValue)
            {
                query = query.Where(s => s.GioiTinh == gioiTinh.Value);
            }

            if (!string.IsNullOrWhiteSpace(soCMND))
            {
                query = query.Where(s => s.SoCMND.IndexOf(soCMND.Trim(), StringComparison.OrdinalIgnoreCase) >= 0);
            }

            if (!string.IsNullOrWhiteSpace(soDT))
            {
                query = query.Where(s => s.SoDT.IndexOf(soDT.Trim(), StringComparison.OrdinalIgnoreCase) >= 0);
            }

            if (!string.IsNullOrWhiteSpace(diaChi))
            {
                query = query.Where(s => s.DiaChi.IndexOf(diaChi.Trim(), StringComparison.OrdinalIgnoreCase) >= 0);
            }

            if (!string.IsNullOrWhiteSpace(monHoc) && monHoc != "Tất cả")
            {
                query = query.Where(s => s.MonHoc != null && s.MonHoc.Any(m => m.IndexOf(monHoc.Trim(), StringComparison.OrdinalIgnoreCase) >= 0));
            }

            return query.ToList();
        }
        #endregion
    }
}
