using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Model
{
    public class Product : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public string GetDetails()
        {
            return $"{this.Id}, {this.Name}, {this.Price}";
        }
    }
}
