using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise__6_desing_pattern
{
    public class RectangleFactory : ShapeFactory
    {
        public override Shape CreateShape()
        {
            return new Rectangle();
        }
    }
}
