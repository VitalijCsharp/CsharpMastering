using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        partial class Book
        {
            private int numbOfPages;

            public int GetPages()
            {
                return numbOfPages;
            }
        }
        partial class Book
        { 
            public Book()
            { }
            public Book(int pages)
            {
                numbOfPages = pages;
            }
        }
        static void Main(string[] args)
        {
            Book roman = new Book(200);
            Console.WriteLine($"Number of pages = {roman.GetPages()}");
        }
    }
}
