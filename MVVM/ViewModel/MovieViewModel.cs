using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesHalløj.MVVM.Model;

namespace MoviesHalløj.MVVM.ViewModel
{
    public class MovieViewModel
    {

        MovieRepo _repository = new MovieRepo();

        public List<Movie> GetAllMovies()
        {
            _repository.load();
            List<Movie> moviesV = new List<Movie>();

            for (int i = 0; i < _repository.GetMovies().Count; i++)
            {
                Movie m = new Movie(_repository.GetMovies()[i].MovieName, _repository.GetMovies()[i].DateTime);
                moviesV.Add(m);
            }
            return moviesV;
        }



    }
}
