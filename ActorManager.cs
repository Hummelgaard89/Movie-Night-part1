using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Night_part1
{
    class ActorManager
    {
        public static List<Actor> ShowActors()
        {
            return DalManager.GetActors();
        }
        public static List<Actor> SearchActors()
        {
            return DalManager.SearchActors();
        }
        //public static Actor AddActor(Actor a)
        //{
        //    return DalManager.AddActor(a);
        //}
    }
}
