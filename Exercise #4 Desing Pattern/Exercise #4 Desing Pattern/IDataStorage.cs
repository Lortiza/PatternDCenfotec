using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise__4_Desing_Pattern
{
    public interface IDataStorage
    {
        void SaveLibrary(Library library);
        Library LoadLibrary();


    }
}
