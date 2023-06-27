using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Northwind.Model;

namespace Northwind.Validation
{
    public class ProductValidation
    {
        public bool Validate(Product product)
        {
            // Validation logic
            Console.WriteLine("Validating product...");
            return true;
        }
    }
}