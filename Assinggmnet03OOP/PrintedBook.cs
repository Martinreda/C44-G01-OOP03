using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assinggmnet03OOP
{
    internal class PrintedBook : Book
    {
        public int PageCount { get; set; }

        public PrintedBook(string title, string author, string isbn, int pageCount)
            : base(title, author, isbn)
        {
            PageCount = (pageCount > 0) ? pageCount : 1;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($" Page Count: {PageCount} pages\n");
        }
    }
}
