using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3DesignPatterns
{

    // 2. Create a Customer class.

    //Similar to Product, encapsulate details relevant to customers such as 
    //Id, Name, and Address.

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
