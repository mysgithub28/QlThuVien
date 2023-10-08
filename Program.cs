using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library a = new Library();
            a.Add(new Book("a", "v", "g", 32, 5));

            Console.ReadKey();
        }
    }
}
