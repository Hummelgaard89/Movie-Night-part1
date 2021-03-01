using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Night_part1
{
    static class MovieManager
    {
        public static List<Movie>ShowMovies()
        {
            return DalManager.GetMovies();
        }
        public static List<Movie> SearchMovies()
        {
            return DalManager.SearchMovies();
        }
        //public static Movie AddMovie(Movie m)
        //{
        //    return DalManager.AddMovie(m);
        //}
    }
}
