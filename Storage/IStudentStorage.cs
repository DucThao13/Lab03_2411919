using System.Collections.Generic;
using ChuDe3_ThaoTacTapTin.Models;

namespace ChuDe3_ThaoTacTapTin.Storage
{
    public interface IStudentStorage
    {
        List<SinhVien> Load(string filePath);
        void Save(string filePath, List<SinhVien> students);
    }
}
