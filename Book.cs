using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    class Book : Items
    {
        private string Author { get; set; }
        private int Year { get; set; }

        public Book () : base ()
        {
            Author = "Unknown";
            Year = 0;
        }
        public Book(string code, string title, string author, int year, int quantity) : base (code,title,quantity)
        {
            Author = author;
            Year = year;
        }
    }
}
