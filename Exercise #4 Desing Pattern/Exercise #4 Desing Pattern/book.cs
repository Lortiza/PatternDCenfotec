using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise__4_Desing_Pattern
{
    public class Book : LibraryItem
    {
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int PublishedYear { get; set; }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Published Year: {PublishedYear}");
        }
    }
}
