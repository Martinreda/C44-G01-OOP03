using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assinggmnet03OOP
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        public Book(string title, string author, string isbn)
        {
            Title = (title != null && title != "") ? title : "Unknown Title";
            Author = (author != null && author != "") ? author : "Unknown Author";
            ISBN = (isbn != null && isbn != "") ? isbn : "N/A";
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}");
        }
    }
}
