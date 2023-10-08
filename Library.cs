using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    internal class Library
    {
        //private List<Book> books;
        //private List<Magazine> magazines;
        private List<Items> items;
        public Library()
        {
            //books = new List<Book>();
            //magazines = new List<Magazine>();
            items = new List<Items>();
        }         
        public void Add(Items item)
        {
            //books.Add(book);
            //magazines.Add(magazine);
            items.Add(item);
        }
        public void Remove(Items item)
        {
            //books.Remove(book);
            //magazines.Remove(magazine);
            items.Remove(item);
        }
        public Items FindByCode(string id)
        {
            //return books.FirstOrDefault(book => book.ID == id);
            //       magazines.FirstOrDefault(magazine => magazine.ID == id);
            return
                items.FirstOrDefault(item => item.ID == id);
        }
        
        public List<Items> FindBookByName(string name)
        {
            //return 
            //    /*books.Where(book => book.Title.Contains(name)).ToList();*/
            if (string.Equals(name, "")) return items;
            else return
                items.Where(item => item.Title.Contains(name)).ToList();
        }
        public void UpdateQuantity(Items item, int quantity)
        {
            if(quantity < 5)
            {
                Console.WriteLine("Số lượng tồn dưới mức vượt phép!!!");
            }
            item.Quantity = quantity;
        }

        public int SoLuong()
        {
            int SumMagazine = 0;
            int SumBook = 0;
            foreach (Items x in items)
            {
                if (x is Magazine)  SumMagazine = SumMagazine + x.Quantity;
                else  SumBook = SumBook + x.Quantity;
            }
            return SumBook;
        }
        public void DisplayInfo()
        {
            foreach (Items a in items)
            {
                if (a is Book)
                    Console.WriteLine($"Book || {a.ID},{a.Title},{a.Quantity}");
                else
                    Console.WriteLine($"Magazine || {a.ID},{a.Title},{a.Quantity}");
            }
        }
    }
}
