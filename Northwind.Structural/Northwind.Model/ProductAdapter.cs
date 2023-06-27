using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Model
{
    public class ProductAdapter : IProductNew
    {
        readonly IProduct p;

        public ProductAdapter(IProduct p)
        {
            this.p = p;
        }

        public string Details()
        {
            return this.p.GetDetails();
        }
    }
}
