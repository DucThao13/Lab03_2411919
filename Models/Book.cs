using System;

namespace ChuDe3_ThaoTacTapTin.Models
{
    /// <summary>
    /// Lớp Book phục vụ phần Thực hành XmlSerializer (Trang 57-58)
    /// </summary>
    [Serializable]
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int YearPublished { get; set; }

        public Book()
        {
        }

        public Book(string isbn, string title, string author, decimal price, int yearPublished)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            Price = price;
            YearPublished = yearPublished;
        }

        public override string ToString()
        {
            return string.Format("{0,-15} {1,-45} {2,-20} {3,8:C} {4,6}",
                ISBN, Title, Author, Price, YearPublished);
        }
    }
}
