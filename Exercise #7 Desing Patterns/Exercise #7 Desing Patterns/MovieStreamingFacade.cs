using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise__7_Desing_Patterns
{
    public class MovieStreamingFacade
    {
        private UserAuthentication userAuthentication;
        private MovieCatalog movieCatalog;
        private VideoPlayer videoPlayer;
        private SubtitleProvider subtitleProvider;

        public MovieStreamingFacade()
        {
            userAuthentication = new UserAuthentication();
            movieCatalog = new MovieCatalog();
            videoPlayer = new VideoPlayer();
            subtitleProvider = new SubtitleProvider();
        }

        public void PlayMovie(string username, string password, string movieTitle)
        {
            bool isAuthenticated = userAuthentication.AuthenticateUser(username, password);

            if (isAuthenticated)
            {
                Movie movie = movieCatalog.GetMovie(movieTitle);
                string subtitles = subtitleProvider.GetSubtitles(movie);
                videoPlayer.PlayVideo(movie);

                Console.WriteLine($"Movie '{movie.Title}' is playing with '{subtitles}' subtitles.");
            }
            else
            {
                Console.WriteLine("User authentication failed. Access denied.");
            }
        }
    }
}
