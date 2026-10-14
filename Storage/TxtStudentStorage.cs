using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using ChuDe3_ThaoTacTapTin.Models;

namespace ChuDe3_ThaoTacTapTin.Storage
{
    /// <summary>
    /// Đọc và ghi danh sách sinh viên với tập tin văn bản (*.txt)
    /// </summary>
    public class TxtStudentStorage : IStudentStorage
    {
        private const char Separator = '*';

        public List<SinhVien> Load(string filePath)
        {
            var list = new List<SinhVien>();
            if (!File.Exists(filePath))
            {
                return list;
            }

            string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                // Hỗ trợ phân cách bằng * hoặc \t
                string[] parts = line.Split(Separator);
                if (parts.Length < 9)
                {
                    parts = line.Split('\t');
                }

                if (parts.Length >= 9)
                {
                    var sv = new SinhVien();
                    sv.MSSV = parts[0].Trim();
                    sv.HoLot = parts[1].Trim();
                    sv.Ten = parts[2].Trim();
                    
                    bool gt = true;
                    if (bool.TryParse(parts[3].Trim(), out gt))
                    {
                        sv.GioiTinh = gt;
                    }
                    else
                    {
                        sv.GioiTinh = (parts[3].Trim().Equals("Nam", StringComparison.OrdinalIgnoreCase) || parts[3].Trim().Equals("1"));
                    }

                    DateTime ns;
                    if (DateTime.TryParseExact(parts[4].Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ns))
                    {
                        sv.NgaySinh = ns;
                    }
                    else if (DateTime.TryParse(parts[4].Trim(), out ns))
                    {
                        sv.NgaySinh = ns;
                    }
                    else
                    {
                        sv.NgaySinh = DateTime.Now;
                    }

                    sv.Lop = parts[5].Trim();
                    sv.SoCMND = parts[6].Trim();
                    sv.SoDT = parts[7].Trim();
                    sv.DiaChi = parts[8].Trim();

                    sv.MonHoc = new List<string>();
                    if (parts.Length >= 10 && !string.IsNullOrWhiteSpace(parts[9]))
                    {
                        string[] mons = parts[9].Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string m in mons)
                        {
                            sv.MonHoc.Add(m.Trim());
                        }
                    }

                    list.Add(sv);
                }
            }

            return list;
        }

        public void Save(string filePath, List<SinhVien> students)
        {
            var lines = new List<string>();
            foreach (var sv in students)
            {
                string monHocStr = sv.MonHoc != null ? string.Join(",", sv.MonHoc) : "";
                string line = string.Format("{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}{1}{9}{1}{10}",
                    sv.MSSV,
                    Separator,
                    sv.HoLot,
                    sv.Ten,
                    sv.GioiTinh ? "Nam" : "Nữ",
                    sv.NgaySinh.ToString("dd/MM/yyyy"),
                    sv.Lop,
                    sv.SoCMND,
                    sv.SoDT,
                    sv.DiaChi,
                    monHocStr
                );
                lines.Add(line);
            }

            string dir = Path.GetDirectoryName(filePath);
            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            File.WriteAllLines(filePath, lines, Encoding.UTF8);
        }
    }
}
