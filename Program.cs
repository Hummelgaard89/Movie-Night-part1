using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Movie_Night_part1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Movie> movies = MovieManager.ShowMovies();
            foreach (Movie movienumber in movies)
            {
                Console.WriteLine(movienumber.Title);
            }
            List<Actor> actors = ActorManager.ShowActors();
            foreach (Actor actornumber in actors)
            {
                Console.WriteLine(actornumber.FirstName + actornumber.LastName);
            }
            List<Movie> searchmovies = MovieManager.SearchMovies();
            foreach (Movie movienumber in searchmovies)
            {
                Console.WriteLine(movienumber.Title + " " + movienumber.Year);
            }
            List<Actor> searchactors = ActorManager.SearchActors();
            foreach (Actor actornumber in searchactors)
            {
                Console.WriteLine(actornumber.FirstName + " " + actornumber.LastName);
            }
            List<Movie> searchmoviesbygenre = GenreManager.SearchGenre();
            foreach (Movie movienumber in searchmoviesbygenre)
            {
                Console.WriteLine(movienumber.Title + " " + movienumber.Year);
            }
            Console.ReadLine();
        }
    }
}
