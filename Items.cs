using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    public class Items
    {
        public string ID;
        public string Title;
        public int Quantity;

        public Items()
        {
            ID = Title = "Unavailable";
            Quantity = 0;
        }
        public Items(string code, string title, int quantity)
        {
            ID = code;
            Title = title;
            Quantity = quantity;
        }
    }
}
