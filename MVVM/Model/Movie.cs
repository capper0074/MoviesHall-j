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
        public string DateTime { get; }


        public Movie(string movieName, string dataTime)
        {
            MovieName = movieName;
            DateTime = dataTime;

        }

        public override string ToString()
        {
            return $"{MovieName} {DateTime}";
        }
        

        
    }
}
