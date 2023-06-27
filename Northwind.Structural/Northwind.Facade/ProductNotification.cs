using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Model;

namespace Northwind.Notification
{
    public class ProductNotification
    {
        public void SendNotification(Product product)
        {
            // Notification logic
            Console.WriteLine("Sending notification...");
        }
    }
}
