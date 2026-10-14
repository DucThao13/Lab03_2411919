using System;

namespace ChuDe3_ThaoTacTapTin.Models
{
    /// <summary>
    /// Lớp mô hình StudentInfo phục vụ phần Thực hành Đọc JSON (Trang 53)
    /// </summary>
    public class StudentInfo
    {
        public string MSSV { get; set; }
        public string Hoten { get; set; }
        public int Tuoi { get; set; }
        public double Diem { get; set; }
        public bool TonGiao { get; set; }

        public StudentInfo()
        {
        }

        public StudentInfo(string mssv, string hoten, int tuoi, double diem, bool tongiao)
        {
            this.MSSV = mssv;
            this.Hoten = hoten;
            this.Tuoi = tuoi;
            this.Diem = diem;
            this.TonGiao = tongiao;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} tuổi - Điểm: {3} - Tôn giáo: {4}", 
                MSSV, Hoten, Tuoi, Diem, TonGiao ? "Có" : "Không");
        }
    }
}
