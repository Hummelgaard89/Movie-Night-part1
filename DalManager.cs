using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Movie_Night_part1
{
    public static class DalManager
    {   
        //The link for my SQL-Database called MovieNight
        private static string connectionpath = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=MovieNight; Integrated Security=SSPI";
        //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=MovieNight; Integrated Security=SSPI");
        #region //Everything with Movies.
        //Gets a list of the movies.
        public static List<Movie> GetMovies()
        {
            //Creates a list called movie.
            List<Movie> movie = new List<Movie>();
            //Closes connection automatic after use, keeps the connection clean.
            using (SqlConnection connection = new SqlConnection(connectionpath))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT MID, title, year FROM Movies", connection);
                SqlDataReader rdr = cmd.ExecuteReader();
                //Reads the data in sequence and creates a new "Movie" and then adds that movie to the list.
                while (rdr.Read())
                {
                    int mid = (int)rdr["MID"];
                    string title = (string)rdr["title"];
                    int year = (int)rdr["year"];
                    Movie m = new Movie(mid, title, year);
                    movie.Add(m);
                }
                return movie;

            }
        }
        public static List<Movie> SearchMovies()
        {
            Console.WriteLine("\n\n\nSøg flim her");
            string textinput = Console.ReadLine();
            List<Movie> searchmovie = new List<Movie>();
            using (SqlConnection connection = new SqlConnection(connectionpath))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT MID, title, year FROM Movies where title like @search", connection);
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter.ParameterName = "@search";
                sqlparameter.Value = "%" + textinput + "%";
                cmd.Parameters.Add(sqlparameter);
                SqlDataReader rdr = cmd.ExecuteReader();
                //Reads the data in sequence and creates a new "Movie" and then adds that movie to the list.
                while (rdr.Read())
                {
                    int mid = (int)rdr["MID"];
                    string title = (string)rdr["title"];
                    int year = (int)rdr["year"];
                    Movie m = new Movie(mid, title, year);
                    searchmovie.Add(m);
                }
                return searchmovie;

            }
        }
        
        #endregion//Everything with movies ending.
        //
        #region//Everything with actors.
        public static List<Actor> GetActors()
        {
            List<Actor> actor = new List<Actor>();
            using (SqlConnection connection = new SqlConnection(connectionpath))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT AID, Firstname, Lastname FROM Actors", connection);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    int aid = (int)rdr["AID"];
                    string firstname = (string)rdr["Firstname"];
                    string lastname = (string)rdr["Lastname"];
                    Actor a = new Actor(aid, firstname, lastname);
                    actor.Add(a);
                }
                return actor;
            }
        }

        public static List<Actor> SearchActors()
        {
            Console.WriteLine("\n\n\nSøg skuespiller her");
            string textinput = Console.ReadLine();
            List<Actor> searchactor = new List<Actor>();
            using (SqlConnection connection = new SqlConnection(connectionpath))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT AID, firstname, lastname FROM Actors where firstname like @search or lastname like @search", connection);
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter.ParameterName = "@search";
                sqlparameter.Value = "%" + textinput + "%";
                cmd.Parameters.Add(sqlparameter);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    int aid = (int)rdr["AID"];
                    string firstname = (string)rdr["Firstname"];
                    string lastname = (string)rdr["Lastname"];
                    Actor a = new Actor(aid, firstname, lastname);
                    searchactor.Add(a);
                }
                return searchactor;

            }
        }
        #endregion//Everything with actors ending.
        #region//Everything with Genre
        public static List<Movie> SearchGenre()
        {
            Console.WriteLine("\n\n\nSøg genre her");
            string textinput = Console.ReadLine();
            List<Movie> searchmovie = new List<Movie>();
            using (SqlConnection connection = new SqlConnection(connectionpath))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select movies.MID, title, year, genre.Genrename from movies " +
                    "join MovieGenre on Movies.MID = MovieGenre.MID join genre on Genre.GID = MovieGenre.GID where Genre.Genrename like '%action%'", connection);
                SqlParameter sqlparameter = new SqlParameter();
                sqlparameter.ParameterName = "@search";
                sqlparameter.Value = "%" + textinput + "%";
                cmd.Parameters.Add(sqlparameter);
                SqlDataReader rdr = cmd.ExecuteReader();
                //Reads the data in sequence and creates a new "Movie" and then adds that movie to the list.
                while (rdr.Read())
                {
                    int mid = (int)rdr["MID"];
                    string title = (string)rdr["title"];
                    int year = (int)rdr["year"];
                    Movie m = new Movie(mid, title, year);
                    searchmovie.Add(m);
                }
                return searchmovie;

            }
        }
        #endregion//Everything with Genre ending.

    }
}
