using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using ChuDe3_ThaoTacTapTin.Models;

namespace ChuDe3_ThaoTacTapTin.Storage
{
    /// <summary>
    /// Đọc và ghi danh sách sinh viên với tập tin XML (*.xml) sử dụng XmlSerializer
    /// </summary>
    public class XmlStudentStorage : IStudentStorage
    {
        public List<SinhVien> Load(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return new List<SinhVien>();
            }

            try
            {
                var serializer = new XmlSerializer(typeof(List<SinhVien>));
                using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    var result = (List<SinhVien>)serializer.Deserialize(stream);
                    return result ?? new List<SinhVien>();
                }
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

            var serializer = new XmlSerializer(typeof(List<SinhVien>));
            using (var writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                serializer.Serialize(writer, students ?? new List<SinhVien>());
            }
        }
    }
}
