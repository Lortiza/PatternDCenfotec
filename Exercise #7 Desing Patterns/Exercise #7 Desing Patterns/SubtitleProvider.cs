using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise__7_Desing_Patterns
{
    public class SubtitleProvider
    {
        public string GetSubtitles(Movie movie)
        {
            // TODO: Implement the logic to retrieve subtitles for the movie
            Console.WriteLine($"Retrieving subtitles for movie: {movie.Title}");
            return "English";
        }
    }
}
