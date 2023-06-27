using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise__4_Desing_Pattern
{
    public class Newspaper : LibraryItem
    {
        public string Publisher { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Edition { get; set; }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Newspaper Title: {Title}");
            Console.WriteLine($"Publisher: {Publisher}");
            Console.WriteLine($"Publication Date: {PublicationDate}");
            Console.WriteLine($"Edition: {Edition}");
           
        }
    }
}
