using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise__4_Desing_Pattern
{
    public class MemoryDataStorage : IDataStorage
    {

        private Library _library;



        public void SaveLibrary(Library library)
        {
            _library = library;
            Console.WriteLine("Library has been saved to memory.");
        }

        public Library LoadLibrary()
        {
            if (_library == null)
            {
                Console.WriteLine("Library is not found in memory. Creating a new library.");
                _library = new Library();
            }
            else
            {
                Console.WriteLine("Library has been loaded from memory.");
            }

            return _library;
        }
    }

}
