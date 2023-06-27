using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Northwind.Model;

namespace Northwind.Data
{
    public class ProductUpdateCommand : ICommand
    {
        readonly Product pM;
        readonly ProductD pD;
        public ProductUpdateCommand(ProductD pD, Product pM)
        {
            this.pD = pD;
            this.pM = pM;
        }
        public void Execute()
        {
            pD.Update(pM);
        }
    }
}
