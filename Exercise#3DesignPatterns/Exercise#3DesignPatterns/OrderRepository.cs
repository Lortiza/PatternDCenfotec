using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3DesignPatterns
{
    public class OrderRepository : IOrderRepository
    {
        private Dictionary<string, Order> _orders;

        public OrderRepository()
        {
            _orders = new Dictionary<string, Order>();
        }

        public void AddOrder(Order order)
        {
            _orders[order.OrderId.ToString()] = order;
        }

        public Order GetOrder(string orderId)
        {
            _orders.TryGetValue(orderId, out Order order);
            return order;
        }
    }
}
