using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ChuDe3_ThaoTacTapTin.Models
{
    /// <summary>
    /// Lớp biểu diễn thông tin sinh viên cho Bài tập Chủ đề 3 (Trang 58-59)
    /// </summary>
    [Serializable]
    public class SinhVien
    {
        public string MSSV { get; set; }
        public string HoLot { get; set; }
        public string Ten { get; set; }
        public bool GioiTinh { get; set; } // true: Nam, false: Nữ
        public DateTime NgaySinh { get; set; }
        public string Lop { get; set; }
        public string SoCMND { get; set; }
        public string SoDT { get; set; }
        public string DiaChi { get; set; }

        [XmlArray("DanhSachMonHoc")]
        [XmlArrayItem("MonHoc")]
        public List<string> MonHoc { get; set; }

        public SinhVien()
        {
            MonHoc = new List<string>();
            NgaySinh = DateTime.Now;
            GioiTinh = true;
        }

        public SinhVien(string mssv, string hoLot, string ten, bool gioiTinh, 
                        DateTime ngaySinh, string lop, string soCMND, string soDT, 
                        string diaChi, List<string> monHoc)
        {
            MSSV = mssv;
            HoLot = hoLot;
            Ten = ten;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            Lop = lop;
            SoCMND = soCMND;
            SoDT = soDT;
            DiaChi = diaChi;
            MonHoc = monHoc ?? new List<string>();
        }

        public string HoVaTen
        {
            get { return (HoLot + " " + Ten).Trim(); }
        }

        public string ChuoiMonHoc
        {
            get
            {
                if (MonHoc == null || MonHoc.Count == 0) return "";
                return string.Join(", ", MonHoc);
            }
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} {2} - Lớp: {3}", MSSV, HoLot, Ten, Lop);
        }
    }
}
