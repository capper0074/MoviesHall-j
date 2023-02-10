using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accessibility;
using MoviesHalløj.MVVM.Model;

namespace MoviesHalløj.MVVM.ViewModel
{
    public class MovieViewModel
    {

        MovieRepo _repository = new MovieRepo();
        List<Movie> moviesV = new List<Movie>();

        public List<Movie> GetAllMovies()
        {
            _repository.RetrieveAll();

            for (int i = 0; i < _repository.GetMovies().Count; i++)
            {
                Movie m = new Movie();
                m.MovieName = _repository.movies[i].MovieName;
                m.MovieDateTime = _repository.movies[i].MovieDateTime;
                moviesV.Add(m);
            }
            return moviesV;
        }
        public void CreateMovie(string movieName, string movieDateTime)
        {
            Movie m = new Movie();
            m.MovieName = movieName;
            m.MovieDateTime = movieDateTime;
            _repository.Create(m);
        }


    }
}
