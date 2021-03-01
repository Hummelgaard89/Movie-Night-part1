using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Night_part1
{
    public class Genre
    {
        private int gid;
        private string genrename;

        public Genre(int _gid, string _genrename)
        {
            this.gid = _gid;
            this.genrename = _genrename;
        }
        public int Gid
        {
            get { return gid; }
            set { gid = value; }
        }
        public string Genrename
        {
            get { return genrename; }
            set { genrename = value; }
        }
    }
}
