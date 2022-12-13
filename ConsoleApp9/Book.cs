using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Book
    {
        public string Name { get; set; }
        public string AutorName { get; set; }
        public int PageCOunt { get; set; }
        public double Price { get; set; }
        private string BookCode { get; set; }
        private static int Queue { get; set; }

        public Book(string name, string authorName, int pageCount, double price)
        {
            Queue++;
            Name = name;
            AutorName = authorName;
            PageCOunt = pageCount;
            Price = price;
            string FLater = Name[0].ToString();

            string Number =Queue.ToString();
            BookCode = FLater +"-"+Number;
            Console.WriteLine(BookCode);
        }
    }
}
