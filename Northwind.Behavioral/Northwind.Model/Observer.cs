using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Model
{
    public class Observer : IObserver
    {
        public void Update(Product p)
        {
            var msg = $"{p.Name}, price: {p.Price} is been updated ...";

            System.Diagnostics.Debug.WriteLine(msg);
        }
    }
}
