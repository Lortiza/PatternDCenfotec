using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3DesignPatterns
{

   // 1. Create a Product class.

   //This class should encapsulate the properties of a product such as Id, Name, 
   //and Price.Create a method that interact with these properties, specifically:  
   //DisplayProductDetails(), to show on console the value of the properties.


    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product ID: {Id}");
            Console.WriteLine($"Product Name: {Name}");
            Console.WriteLine($"Product Price: {Price:C}");
        }
    }


  


   

}
