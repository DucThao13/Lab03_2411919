using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ChuDe3_ThaoTacTapTin.Models;
using Newtonsoft.Json;

namespace ChuDe3_ThaoTacTapTin.Storage
{
    /// <summary>
    /// Đọc và ghi danh sách sinh viên với tập tin JSON (*.json) sử dụng Newtonsoft.Json
    /// </summary>
    public class JsonStudentStorage : IStudentStorage
    {
        public List<SinhVien> Load(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return new List<SinhVien>();
            }

            try
            {
                string json = File.ReadAllText(filePath, Encoding.UTF8);
                var list = JsonConvert.DeserializeObject<List<SinhVien>>(json);
                return list ?? new List<SinhVien>();
            }
            catch
            {
                return new List<SinhVien>();
            }
        }

        public void Save(string filePath, List<SinhVien> students)
        {
            string dir = Path.GetDirectoryName(filePath);
            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            string json = JsonConvert.SerializeObject(students ?? new List<SinhVien>(), Formatting.Indented);
            File.WriteAllText(filePath, json, Encoding.UTF8);
        }
    }
}
