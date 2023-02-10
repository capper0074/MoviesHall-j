using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Runtime.ConstrainedExecution;

namespace MoviesHalløj.MVVM.Model
{
    public class MovieRepo
    {

       // private string filePath = @"..\..\..\Data\Data.txt";

        public List<Movie> movies = new List<Movie>();

        public void Create(Movie movieToBeCreated)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseServerInstance"].ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO MOVIES (MovieName, MovieDateTime)" + "VALUES(@MovieName, @MovieDateTime)"
                    , con);
                cmd.Parameters.Add("@MovieName", SqlDbType.VarChar).Value = movieToBeCreated.MovieName;
                cmd.Parameters.Add("@MovieDateTime", SqlDbType.Date).Value = movieToBeCreated.MovieDateTime;
                cmd.ExecuteNonQuery();
            }
        }

        public void RetrieveAll()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseServerInstance"].ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT MovieName, MovieDateTime FROM MOVIES", con);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Movie mv = new Movie();
                        mv.MovieName = dr["MovieName"].ToString();
                        mv.MovieDateTime = dr["MovieDateTime"].ToString();

                        movies.Add(mv);
                    }
                }
            }
        }
        public List<Movie> GetMovies()
        {
            return movies;
        }
    }

}
