using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ChuDe3_ThaoTacTapTin.BLL;
using ChuDe3_ThaoTacTapTin.Models;

namespace ChuDe3_ThaoTacTapTin.Forms
{
    public partial class frmSinhVien : Form
    {
        private QuanLySinhVien _qlsv;
        private string _dataPath;

        public frmSinhVien()
        {
            InitializeComponent();
            _qlsv = new QuanLySinhVien();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            // Thiết lập giá trị cho combobox lớp
            cboLop.Items.Clear();
            cboLop.Items.Add("CTK43");
            cboLop.Items.Add("CTK44");
            cboLop.Items.Add("CTK45");
            cboLop.Items.Add("CTK46");
            cboLop.Items.Add("CTK47");
            cboLop.Items.Add("CTK48");
            cboLop.SelectedIndex = 5; // Mặc định CTK48

            // Khởi tạo các môn học mặc định trong CheckedListBox theo hình trang 58
            KhoiTaoDanhSachMonHocMacDinh();

            // Xác định thư mục dữ liệu Data/
            _dataPath = Path.Combine(Application.StartupPath, "Data");
            if (!Directory.Exists(_dataPath))
            {
                string fallback = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Data");
                if (Directory.Exists(fallback))
                {
                    _dataPath = Path.GetFullPath(fallback);
                }
                else
                {
                    Directory.CreateDirectory(_dataPath);
                }
            }

            // Tự động tải dữ liệu sinh viên từ file khi khởi động chương trình (Yêu cầu 2)
            TaiDuLieuMacDinh();

            // Đặt form về trạng thái mặc định
            ThietLapMacDinh();
        }

        private void KhoiTaoDanhSachMonHocMacDinh()
        {
            clbMonHoc.Items.Clear();
            string[] cacMonHoc = new string[]
            {
                "Mạng máy tính",
                "Đồ án cơ sở",
                "Hệ điều hành",
                "Phương pháp NCKH",
                "Lập trình CSDL",
                "Lập trình trên thiết bị di động",
                "Lập trình mạng",
                "An toàn và bảo mật hệ thống"
            };

            foreach (var mon in cacMonHoc)
            {
                clbMonHoc.Items.Add(mon);
            }
        }

        private void TaiDuLieuMacDinh()
        {
            // Ưu tiên nạp students.json, nếu không thì students.xml, hoặc students.txt
            string jsonFile = Path.Combine(_dataPath, "students.json");
            string xmlFile = Path.Combine(_dataPath, "students.xml");
            string txtFile = Path.Combine(_dataPath, "students.txt");

            if (File.Exists(jsonFile))
            {
                _qlsv.DocTuFile(jsonFile, FileFormatType.JSON);
            }
            else if (File.Exists(xmlFile))
            {
                _qlsv.DocTuFile(xmlFile, FileFormatType.XML);
            }
            else if (File.Exists(txtFile))
            {
                _qlsv.DocTuFile(txtFile, FileFormatType.TXT);
            }

            HienThiDanhSachSinhVien();
        }

        private void HienThiDanhSachSinhVien()
        {
            lvSinhVien.Items.Clear();
            foreach (var sv in _qlsv.DanhSach)
            {
                ThemSinhVienVaoListView(sv);
            }

            CapNhatThanhTrangThai();
        }

        private void ThemSinhVienVaoListView(SinhVien sv)
        {
            var item = new ListViewItem(sv.MSSV);
            item.SubItems.Add(sv.HoLot);
            item.SubItems.Add(sv.Ten);
            item.SubItems.Add(sv.GioiTinh ? "Nam" : "Nữ");
            item.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
            item.SubItems.Add(sv.Lop);
            item.SubItems.Add(sv.SoCMND);
            item.SubItems.Add(DinhDangSoDienThoai(sv.SoDT));
            item.SubItems.Add(sv.DiaChi);
            item.SubItems.Add(sv.ChuoiMonHoc);
            item.Tag = sv;

            lvSinhVien.Items.Add(item);
        }

        private string DinhDangSoDienThoai(string sdt)
        {
            if (string.IsNullOrEmpty(sdt) || sdt.Length != 10) return sdt;
            // Phân tách thành 3 nhóm (theo hình: 0000.000.000)
            return string.Format("{0}.{1}.{2}", sdt.Substring(0, 4), sdt.Substring(4, 3), sdt.Substring(7, 3));
        }

        private string LaySoThuanTuMask(MaskedTextBox mtxt)
        {
            string raw = mtxt.Text;
            return Regex.Replace(raw, @"[^\d]", "");
        }

        private void CapNhatThanhTrangThai()
        {
            string tenTep = string.IsNullOrEmpty(_qlsv.DuongDanHienTai) ? "Chưa lưu" : Path.GetFileName(_qlsv.DuongDanHienTai);
            lblStatusTepTin.Text = string.Format("Tệp tin hiện tại: {0} ({1})", tenTep, _qlsv.DinhDangHienTai);
            lblStatusTongSo.Text = string.Format("Tổng số: {0} sinh viên", _qlsv.DanhSach.Count);
        }

        private void ThietLapMacDinh()
        {
            mtxtMSSV.Clear();
            txtHoLot.Clear();
            txtTen.Clear();
            radNam.Checked = true;
            dtpNgaySinh.Value = DateTime.Now;
            mtxtCMND.Clear();
            mtxtSDT.Clear();
            txtDiaChi.Clear();

            for (int i = 0; i < clbMonHoc.Items.Count; i++)
            {
                clbMonHoc.SetItemChecked(i, false);
            }

            // Gợi ý tiền tố MSSV dựa theo lớp
            CapNhatGoiYMaoMSSV();

            mtxtMSSV.Focus();
        }

        private void CapNhatGoiYMaoMSSV()
        {
            if (cboLop.SelectedItem != null)
            {
                string lop = cboLop.SelectedItem.ToString();
                string aa = QuanLySinhVien.LayHaiSoCuoiNamNhapHoc(lop);
                if (!string.IsNullOrEmpty(aa))
                {
                    // Nếu MSSV đang trống hoặc chỉ có phần gợi ý cũ
                    string current = LaySoThuanTuMask(mtxtMSSV);
                    if (string.IsNullOrEmpty(current) || current.Length <= 4)
                    {
                        mtxtMSSV.Text = aa + "10";
                    }
                }
            }
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatGoiYMaoMSSV();
        }

        #region Đọc dữ liệu từ form thành đối tượng SinhVien
        private SinhVien ThuThapThongTinTuForm()
        {
            var sv = new SinhVien();
            sv.MSSV = LaySoThuanTuMask(mtxtMSSV);
            sv.HoLot = txtHoLot.Text.Trim();
            sv.Ten = txtTen.Text.Trim();
            sv.GioiTinh = radNam.Checked;
            sv.NgaySinh = dtpNgaySinh.Value;
            sv.Lop = cboLop.SelectedItem != null ? cboLop.SelectedItem.ToString() : "";
            sv.SoCMND = LaySoThuanTuMask(mtxtCMND);
            sv.SoDT = LaySoThuanTuMask(mtxtSDT);
            sv.DiaChi = txtDiaChi.Text.Trim();

            sv.MonHoc = new List<string>();
            foreach (var item in clbMonHoc.CheckedItems)
            {
                sv.MonHoc.Add(item.ToString());
            }

            return sv;
        }

        private void DienThongTinLenForm(SinhVien sv)
        {
            if (sv == null) return;

            mtxtMSSV.Text = sv.MSSV;
            txtHoLot.Text = sv.HoLot;
            txtTen.Text = sv.Ten;
            if (sv.GioiTinh) radNam.Checked = true;
            else radNu.Checked = true;

            dtpNgaySinh.Value = sv.NgaySinh;

            int lopIdx = cboLop.Items.IndexOf(sv.Lop);
            if (lopIdx >= 0) cboLop.SelectedIndex = lopIdx;
            else
            {
                cboLop.Items.Add(sv.Lop);
                cboLop.SelectedItem = sv.Lop;
            }

            mtxtCMND.Text = sv.SoCMND;
            mtxtSDT.Text = sv.SoDT;
            txtDiaChi.Text = sv.DiaChi;

            // Đánh dấu các môn học đã chọn
            for (int i = 0; i < clbMonHoc.Items.Count; i++)
            {
                string tenMon = clbMonHoc.Items[i].ToString();
                bool isChecked = sv.MonHoc != null && sv.MonHoc.Contains(tenMon);
                clbMonHoc.SetItemChecked(i, isChecked);
            }
        }
        #endregion

        #region Sự kiện chọn sinh viên trên ListView
        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count > 0)
            {
                var item = lvSinhVien.SelectedItems[0];
                var sv = item.Tag as SinhVien;
                if (sv != null)
                {
                    DienThongTinLenForm(sv);
                }
            }
        }
        #endregion

        #region Các nút chức năng chính: Thêm mới, Cập nhật, Tìm kiếm, Thoát
        // 1. Nút Thêm mới
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            SinhVien sv = ThuThapThongTinTuForm();
            string thongBaoLoi;

            if (!_qlsv.ThemSinhVien(sv, out thongBaoLoi))
            {
                MessageBox.Show(thongBaoLoi, "Thông báo lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HienThiDanhSachSinhVien();
            MessageBox.Show(string.Format("Đã thêm thành công sinh viên '{0}'!", sv.HoVaTen), "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ThietLapMacDinh();
        }

        // 2. Nút Cập nhật
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SinhVien sv = ThuThapThongTinTuForm();
            string thongBaoLoi;

            if (!_qlsv.CapNhatSinhVien(sv, out thongBaoLoi))
            {
                MessageBox.Show(thongBaoLoi, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HienThiDanhSachSinhVien();
            MessageBox.Show(string.Format("Đã cập nhật thông tin sinh viên '{0}' thành công!", sv.HoVaTen), "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 3. Nút Tìm kiếm
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (var frm = new frmTimKiem(_qlsv))
            {
                if (frm.ShowDialog() == DialogResult.OK && frm.SinhVienDuocChon != null)
                {
                    // Chọn sinh viên này trong ListView và điền lên form
                    ChonSinhVienTrenListView(frm.SinhVienDuocChon.MSSV);
                    DienThongTinLenForm(frm.SinhVienDuocChon);
                }
            }
        }

        private void ChonSinhVienTrenListView(string mssv)
        {
            foreach (ListViewItem item in lvSinhVien.Items)
            {
                if (item.Text.Equals(mssv, StringComparison.OrdinalIgnoreCase))
                {
                    item.Selected = true;
                    item.EnsureVisible();
                    break;
                }
            }
        }

        // 4. Nút Thoát (Yêu cầu 2: hỏi xác nhận)
        private void btnThoat_Click(object sender, EventArgs e)
        {
            XacNhanThoat();
        }

        private void frmSinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình hay không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void XacNhanThoat()
        {
            this.Close();
        }
        #endregion

        #region Xử lý ContextMenu trên Môn học (Yêu cầu 2: Thêm môn, Xóa môn)
        private void menuThemMon_Click(object sender, EventArgs e)
        {
            using (var frm = new frmThemMonHoc())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    string tenMon = frm.TenMonHoc;
                    foreach (var item in clbMonHoc.Items)
                    {
                        if (item.ToString().Equals(tenMon, StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show("Môn học này đã tồn tại trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    clbMonHoc.Items.Add(tenMon, true);
                    MessageBox.Show(string.Format("Đã thêm môn học '{0}' thành công!", tenMon), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void menuXoaMon_Click(object sender, EventArgs e)
        {
            if (clbMonHoc.SelectedIndex >= 0)
            {
                string tenMon = clbMonHoc.SelectedItem.ToString();
                var confirm = MessageBox.Show(string.Format("Bạn có chắc muốn xóa môn học '{0}' không?", tenMon), "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    clbMonHoc.Items.RemoveAt(clbMonHoc.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn môn học cần xóa trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Xử lý ContextMenu trên ListView (Yêu cầu 2: Xóa 1 hoặc nhiều sinh viên bằng Checkbox)
        private void menuXoaSinhVien_Click(object sender, EventArgs e)
        {
            var dsMssvCanXoa = new List<string>();

            // Lấy các sinh viên được tích Checkbox
            foreach (ListViewItem item in lvSinhVien.CheckedItems)
            {
                dsMssvCanXoa.Add(item.Text);
            }

            // Nếu không có checkbox nào, lấy item đang được chọn bằng chuột
            if (dsMssvCanXoa.Count == 0 && lvSinhVien.SelectedItems.Count > 0)
            {
                dsMssvCanXoa.Add(lvSinhVien.SelectedItems[0].Text);
            }

            if (dsMssvCanXoa.Count == 0)
            {
                MessageBox.Show("Vui lòng tích chọn (checkbox) ít nhất một sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var hoi = MessageBox.Show(string.Format("Bạn có chắc chắn muốn xóa {0} sinh viên đã chọn khỏi danh sách và lưu vào file không?", dsMssvCanXoa.Count),
                                      "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (hoi == DialogResult.Yes)
            {
                int xoaDuoc = _qlsv.XoaDanhSachSinhVien(dsMssvCanXoa);
                HienThiDanhSachSinhVien();
                ThietLapMacDinh();
                MessageBox.Show(string.Format("Đã xóa thành công {0} sinh viên và lưu vào file!", xoaDuoc), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void menuChonTatCa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvSinhVien.Items)
            {
                item.Checked = true;
            }
        }

        private void menuBoChonTatCa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvSinhVien.Items)
            {
                item.Checked = false;
            }
        }
        #endregion

        #region Menu Đọc / Ghi các định dạng file (JSON, XML, TXT)
        private void menuNapJSON_Click(object sender, EventArgs e)
        {
            string file = Path.Combine(_dataPath, "students.json");
            NapFileTheoDinhDang(file, FileFormatType.JSON);
        }

        private void menuNapXML_Click(object sender, EventArgs e)
        {
            string file = Path.Combine(_dataPath, "students.xml");
            NapFileTheoDinhDang(file, FileFormatType.XML);
        }

        private void menuNapTXT_Click(object sender, EventArgs e)
        {
            string file = Path.Combine(_dataPath, "students.txt");
            NapFileTheoDinhDang(file, FileFormatType.TXT);
        }

        private void NapFileTheoDinhDang(string path, FileFormatType type)
        {
            if (!File.Exists(path))
            {
                MessageBox.Show("Không tìm thấy tệp: " + path, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _qlsv.DocTuFile(path, type);
            HienThiDanhSachSinhVien();
            MessageBox.Show(string.Format("Đã nạp {0} sinh viên từ file {1} thành công!", _qlsv.DanhSach.Count, Path.GetFileName(path)), "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuLuuJSON_Click(object sender, EventArgs e)
        {
            string file = Path.Combine(_dataPath, "students.json");
            _qlsv.GhiRaFile(file, FileFormatType.JSON);
            CapNhatThanhTrangThai();
            MessageBox.Show("Đã lưu danh sách sinh viên vào tệp JSON: " + file, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuLuuXML_Click(object sender, EventArgs e)
        {
            string file = Path.Combine(_dataPath, "students.xml");
            _qlsv.GhiRaFile(file, FileFormatType.XML);
            CapNhatThanhTrangThai();
            MessageBox.Show("Đã lưu danh sách sinh viên vào tệp XML: " + file, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuLuuTXT_Click(object sender, EventArgs e)
        {
            string file = Path.Combine(_dataPath, "students.txt");
            _qlsv.GhiRaFile(file, FileFormatType.TXT);
            CapNhatThanhTrangThai();
            MessageBox.Show("Đã lưu danh sách sinh viên vào tệp TXT: " + file, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuMoTepKhac_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Tất cả tệp hỗ trợ (*.json;*.xml;*.txt)|*.json;*.xml;*.txt|JSON Files (*.json)|*.json|XML Files (*.xml)|*.xml|Text Files (*.txt)|*.txt";
                ofd.InitialDirectory = _dataPath;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var format = QuanLySinhVien.XacDinhDinhDangTuDuongDan(ofd.FileName);
                    _qlsv.DocTuFile(ofd.FileName, format);
                    HienThiDanhSachSinhVien();
                    MessageBox.Show(string.Format("Đã nạp thành công {0} sinh viên từ: {1}", _qlsv.DanhSach.Count, ofd.FileName), "Thành công");
                }
            }
        }

        private void menuLuuTepThanh_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "JSON Files (*.json)|*.json|XML Files (*.xml)|*.xml|Text Files (*.txt)|*.txt";
                sfd.InitialDirectory = _dataPath;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var format = QuanLySinhVien.XacDinhDinhDangTuDuongDan(sfd.FileName);
                    _qlsv.GhiRaFile(sfd.FileName, format);
                    CapNhatThanhTrangThai();
                    MessageBox.Show("Đã lưu tệp thành công vào: " + sfd.FileName, "Thành công");
                }
            }
        }
        #endregion

        #region Mở Demo Hướng dẫn thực hành (Trang 51 - 58)
        private void menuDemoThucHanh_Click(object sender, EventArgs e)
        {
            using (var frm = new frmDemoThucHanh())
            {
                frm.ShowDialog();
            }
        }

        private void menuGioiThieu_Click(object sender, EventArgs e)
        {
            string msg = "BÀI TẬP CHỦ ĐỀ 3: THAO TÁC TẬP TIN (Trang 51 - 59)\r\n\r\n"
                       + "1. Quản lý sinh viên với đầy đủ chức năng Thêm mới, Cập nhật, Xóa, Tìm kiếm.\r\n"
                       + "2. Hỗ trợ đọc/ghi 3 định dạng: *.txt, *.xml, *.json.\r\n"
                       + "3. Quy tắc MSSV AABBCCC theo lớp (AA: 2 số cuối năm nhập học, BB: 10, CCC: số bất kỳ).\r\n"
                       + "4. Chuột phải Môn học để Thêm/Xóa môn.\r\n"
                       + "5. Chuột phải Danh sách sinh viên để Xóa các sinh viên chọn theo Checkbox.\r\n"
                       + "6. Tích hợp form Demo các phần thực hành mẫu từ trang 51 đến 58.";
            MessageBox.Show(msg, "Giới thiệu Chủ đề 3", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
