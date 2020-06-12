using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies_and_Series
{
    //Because a Series episode a short movie
    public class Series : Movie
    {
        public Series(string Name, string Year, string Description,string Season, string Episode, params string[] Actors) : base(Name,Year, Description,  Actors)
        {
            this.Season = Convert.ToInt32(Season);
            this.Episode = Convert.ToInt32(Episode);
        }
        public int Season { get; set ; }
        public int Episode { get; set; }
    }
}
