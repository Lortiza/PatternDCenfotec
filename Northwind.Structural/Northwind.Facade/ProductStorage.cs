using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Northwind.Model;

namespace Northwind.Storage
{
    public class ProductStorage
    {
        public void Save(Product product)
        {
            // Storage logic
            Console.WriteLine("Saving product...");
        }
    }
}