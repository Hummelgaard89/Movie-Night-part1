using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Night_part1
{
    public class Actor
    {
        private int aid;
        private string firstname;
        private string lastname;

        public Actor(string _firstname, string _lastname)
        {
            this.firstname = _firstname;
            this.lastname = _lastname;
        }
        public Actor(int id, string _firstname, string _lastname)
            :this(_firstname, _lastname)
        {
            this.aid = id;
        }

        public int Aid
        {
            get { return aid; }
            set { aid = value; }
        }
        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }
    }
}
