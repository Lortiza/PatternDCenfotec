using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3DesignPatterns
{
    // 3. Create an Order class.

    //This class should have properties such as OrderId, Customer, and a list of
    //OrderItems.An OrderItem should include Product and Quantity.

    public class Order
    {
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        public Order(Customer customer)
        {

            // 4. Composition

            //In the Order class, use composition to include a Customer object and a
            //list of OrderItem objects.
            Customer = customer;
            OrderItems = new List<OrderItem>();
        }
        //     5. High Cohesion.

        //Keep all the methods that manipulate the Order object within the Order class, 
        //such as AddOrderItem(OrderItem item), RemoveOrderItem(OrderItem item), CalculateTotalPrice(),
        //implement it.

        public void AddOrderItem(OrderItem item)
        {
            OrderItems.Add(item);
        }

        public void RemoveOrderItem(OrderItem item)
        {
            OrderItems.Remove(item);
        }

        public decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (var orderItem in OrderItems)
            {
                totalPrice += orderItem.Product.Price * orderItem.Quantity;
            }

            return totalPrice;
        }
    }

    public class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
