using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using ChuDe3_ThaoTacTapTin.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ChuDe3_ThaoTacTapTin.Forms
{
    public partial class frmDemoThucHanh : Form
    {
        public frmDemoThucHanh()
        {
            InitializeComponent();
        }

        #region Trang 51: Thao tác file văn bản
        private void btnGhiDocText_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = Path.Combine(Application.StartupPath, "sample_text.txt");
                string[] text = new string[]
                {
                    "Dòng 1: Bài thực hành Chủ đề 3 - Thao tác tập tin",
                    "Dòng 2: Môn học: Lập trình Windows Form C#",
                    "Dòng 3: Khoa Công Nghệ Thông Tin - Đại Học Đà Lạt",
                    "Dòng 4: Sử dụng lớp System.IO.File để đọc và ghi tập tin."
                };

                // Ghi dữ liệu text vào file filename (Trang 51)
                File.WriteAllLines(filename, text);

                txtLogText.Clear();
                txtLogText.AppendText("=== ĐÃ GHI VÀO FILE: " + filename + " ===\r\n\r\n");

                // Đọc dữ liệu từ file filename hiển thị ra màn hình (Trang 51)
                foreach (string s in File.ReadAllLines(filename))
                {
                    txtLogText.AppendText(s + "\r\n");
                }

                MessageBox.Show("Đã ghi và đọc tập tin text thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Trang 52 - 54: Đọc tập tin JSON với Newtonsoft.Json
        private List<StudentInfo> LoadJSON(string path)
        {
            // Khai báo danh sách lưu trữ (Trang 54)
            List<StudentInfo> list = new List<StudentInfo>();

            if (!File.Exists(path))
            {
                MessageBox.Show("Không tìm thấy file: " + path, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return list;
            }

            // Đối tượng đọc tập tin
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd(); // Đọc hết

                // Chuyển về thành mảng các đối tượng (Trang 54)
                var array = (JObject)JsonConvert.DeserializeObject(json);

                // Lấy đối tượng sinhvien
                var students = array["sinhvien"].Children();
                foreach (var item in students) // Duyệt mảng
                {
                    // Lấy các thành phần
                    string mssv = item["MSSV"].Value<string>();
                    string hoten = item["hoten"].Value<string>();
                    int tuoi = item["tuoi"].Value<int>();
                    double diem = item["diem"].Value<double>();
                    bool tongiao = item["tongiao"].Value<bool>();

                    // Chuyển vào đối tượng StudentInfo
                    StudentInfo info = new StudentInfo(mssv, hoten, tuoi, diem, tongiao);
                    list.Add(info); // Thêm vào danh sách
                }
            }
            return list;
        }

        private void btnReadJSON_Click(object sender, EventArgs e)
        {
            try
            {
                // Đường dẫn tập tin demo_students.json
                string path = Path.Combine(Application.StartupPath, "Data", "demo_students.json");
                if (!File.Exists(path))
                {
                    path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Data\\demo_students.json");
                }

                List<StudentInfo> list = LoadJSON(path);

                string str = "";
                txtLogJSON.Clear();
                txtLogJSON.AppendText("=== KẾT QUẢ ĐỌC TẬP TIN JSON (Trang 52-54) ===\r\n\r\n");

                for (int i = 0; i < list.Count; i++)
                {
                    StudentInfo info = list[i];
                    string row = string.Format("Sinh viên {0} có MSSV: {1}, họ tên: {2}, điểm TB: {3}\r\n",
                        (i + 1), info.MSSV, info.Hoten, info.Diem);
                    str += row;
                    txtLogJSON.AppendText(row);
                }

                // Hiển thị hộp thoại MessageBox đúng như mẫu trang 54
                MessageBox.Show(str, "Thông tin sinh viên từ JSON");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Trang 55 - 58: Đọc và ghi tập tin XML
        // 1. Đọc XML bằng XmlDocument & XPath (Trang 55-56)
        private void btnDocXmlDoc_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Application.StartupPath, "Data", "books.xml");
                if (!File.Exists(path))
                {
                    path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Data\\books.xml");
                }

                var xmlDoc = new XmlDocument();
                xmlDoc.Load(path);

                var nodeList = xmlDoc.DocumentElement.SelectNodes("/catalog/book");
                txtLogXML.Clear();
                txtLogXML.AppendText("=== ĐỌC TẬP TIN XML BẰNG XmlDocument & XPath (Trang 55-56) ===\r\n\r\n");
                txtLogXML.AppendText(string.Format("{0,-15} {1,-45} {2,-15} {3,-15} {4,6}\r\n", "ISBN", "Title", "First Name", "Last Name", "Price"));
                txtLogXML.AppendText(new string('-', 95) + "\r\n");

                foreach (XmlNode node in nodeList)
                {
                    var isbn = node.Attributes["ISBN"].Value;
                    var title = node.SelectSingleNode("title").InnerText;
                    var price = node.SelectSingleNode("price").InnerText;
                    var firstName = node.SelectSingleNode("author/first-name").InnerText;
                    var lastName = node.SelectSingleNode("author/last-name").InnerText;

                    txtLogXML.AppendText(string.Format("{0,-15} {1,-45} {2,-15} {3,-15} {4,6}\r\n",
                        isbn, title, firstName, lastName, price));
                }

                MessageBox.Show("Đã đọc tập tin books.xml bằng XmlDocument thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. Ghi XML bằng XmlWriter (Trang 56-57)
        private void btnGhiXmlWriter_Click(object sender, EventArgs e)
        {
            try
            {
                string outPath = Path.Combine(Application.StartupPath, "books_writer_demo.xml");

                using (XmlWriter writer = XmlWriter.Create(outPath))
                {
                    // Write Processing Instruction
                    string pi = "type=\"text/xsl\" href=\"book.xsl\"";
                    writer.WriteProcessingInstruction("xml-stylesheet", pi);

                    // Write DocumentType
                    writer.WriteDocType("catalog", null, null, "<!ENTITY h \"hardcover\">");

                    // Write a Comment
                    writer.WriteComment("This is a book sample XML");

                    // Root element - start tag
                    writer.WriteStartElement("book");

                    // Write ISBN attribute
                    writer.WriteAttributeString("ISBN", "9831123212");

                    // Write year attribute
                    writer.WriteAttributeString("yearpublished", "2002");

                    // Write title
                    writer.WriteElementString("author", "Mahesh Chand");
                    writer.WriteElementString("title", "Visual C# Programming");
                    writer.WriteElementString("price", "44.95");

                    // Root element - end tag
                    writer.WriteEndElement();

                    // End Document
                    writer.WriteEndDocument();
                    writer.Flush();
                }

                txtLogXML.Clear();
                txtLogXML.AppendText("=== ĐÃ GHI FILE XML BẰNG XmlWriter (Trang 56-57) ===\r\n\r\n");
                txtLogXML.AppendText(File.ReadAllText(outPath));

                MessageBox.Show("Đã ghi file books_writer_demo.xml bằng XmlWriter thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. Ghi XML bằng XmlSerializer (Trang 57-58)
        private void btnXmlSerializer_Click(object sender, EventArgs e)
        {
            try
            {
                var books = new List<Book>
                {
                    new Book("9831123212", "A Programmer's Guide to ADO .Net using C#", "Mahesh Chand", 44.99m, 2002),
                    new Book("9781484234", "Pro Entity Framework Core 1", "Adam Freeman", 44.99m, 2018)
                };

                string outPath = Path.Combine(Application.StartupPath, "books_serialized.xml");

                var serializer = new XmlSerializer(typeof(List<Book>));
                using (var writer = new StreamWriter(outPath))
                {
                    serializer.Serialize(writer, books, null);
                    writer.Close();
                }

                txtLogXML.Clear();
                txtLogXML.AppendText("=== ĐÃ GHI FILE XML BẰNG XmlSerializer (Trang 57-58) ===\r\n\r\n");
                txtLogXML.AppendText(File.ReadAllText(outPath));

                MessageBox.Show("Đã serialize danh sách Book thành XML thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
