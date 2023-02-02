using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesHalløj.MVVM.Model
{
    public class Movie
    {
        public string MovieName { get; }
        public string MovieTime { get; }

        public Movie(string movieName, string dateTime)
        {
            MovieName = movieName;
            MovieTime = dateTime;
        }

        public override string ToString()
        {
            return MovieName;
        }
        

        
    }
}
