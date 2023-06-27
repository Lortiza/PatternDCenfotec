using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3DesignPatterns
{

   // 6. Low Coupling.

   //Introduce an IOrderRepository interface with methods like AddOrder(Order order)
   //and GetOrder(string orderId). Implement this interface in OrderRepository class. 
   //This will allow the storage of orders to be decoupled from the Order class itself.
    public interface IOrderRepository
    {

        void AddOrder(Order order);
        Order GetOrder(string orderId);


    }

   

}
