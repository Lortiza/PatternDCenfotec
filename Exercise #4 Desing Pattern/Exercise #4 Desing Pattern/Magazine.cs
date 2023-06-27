using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise__4_Desing_Pattern
{
    public class Magazine : LibraryItem
    {
        public string Publisher { get; set; }
        public string Issue { get; set; }
        public int PublicationYear { get; set; }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Magazine Title: {Title}");
            Console.WriteLine($"Publisher: {Publisher}");
            Console.WriteLine($"Issue: {Issue}");
            Console.WriteLine($"Publication Year: {PublicationYear}");
           
        }
    }
}
