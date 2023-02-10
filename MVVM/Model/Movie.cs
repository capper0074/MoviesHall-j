using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesHalløj.MVVM.Model
{
    public class Movie
    {
        public string MovieName { get; set; }
        public string MovieDateTime { get; set; }


        //public Movie(string movieName, string dataTime)
        //{
        //    MovieName = movieName;
        //    MovieDateTime = dataTime;

        //}

        public override string ToString()
        {
            return $"{MovieName} | {MovieDateTime}";
        }
        

        
    }
}
