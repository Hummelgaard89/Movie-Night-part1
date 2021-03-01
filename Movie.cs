using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Night_part1
{
    public class Movie
    {
        private int mid;
        private string title;
        private int year;
        //private string genre;

        public Movie(string _title, int _year)
        {
            this.title = _title;
            this.year = _year;
        }
        public Movie(int _mid, string _title, int _year)
            :this(_title, _year)
        {
            this.mid = _mid;

        }
        public int Mid
        {
            get { return mid; }
            set { mid = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        //public string Genre
        //{
        //    get { return genre; }
        //    set { genre = value; }
        //}
    }
}
