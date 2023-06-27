using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise__7_Desing_Patterns
{
    public class MovieCatalog
    {
        public Movie GetMovie(string title)
        {
            // TODO: Implement the logic to retrieve the movie from the catalog
            Console.WriteLine($"Retrieving movie: {title}");
            return new Movie(title);
        }
    }
}
