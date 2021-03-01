using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Night_part1
{
    class GenreManager
    {
        public static List<Movie> SearchGenre()
        {
            return DalManager.SearchGenre();
        }
    }
}
