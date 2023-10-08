using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    class Magazine : Items
    {
        public string Publisher;

        public Magazine(string code, string title, int quantity, string publisher) : base(code,title,quantity)
        {
            Publisher = publisher;
        }
        public Magazine() : base ()
        {
            Publisher = "Unknown";
        }
    }
}
