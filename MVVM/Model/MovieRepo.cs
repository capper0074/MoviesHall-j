using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesHalløj.MVVM.Model
{
    public class MovieRepo
    {
        private string filePath = @"";

        List<Movie> movies = new List<Movie>();

        public void load()
        {
            string text;

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while((text = sr.ReadLine()) != null)
                    {
                        string[] data = text.Split(",", StringSplitOptions.RemoveEmptyEntries);
                        Movie newMovie = new Movie(data[3]);
                        movies.Add(newMovie);
                    }
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e);

            }
        }
        public void GetMovies()
        {
            for (int i = 0; i < movies.Count; i++)
            {
                Console.WriteLine(movies[i].ToString());
            }
        }
    }

}
