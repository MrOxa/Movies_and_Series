using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Movies_and_Series
{
    public class Movie
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public List<string> Actors { get; set; } = new List<string>();
        public string Description { get; set; }
        public bool isStared { get; set; }

        public Movie(string Name, string Year, string Description, params string[] Actors)
        {
            this.Name = Name;
            this.Year = Convert.ToInt32(Year);
            this.Description = Description;
            for (int i = 0; i < Actors.Length; i++)
            {
                this.Actors.Add(Actors[i]);
            }
            isStared = false;
        }
        public string ConcatingActors()
        {
            StringBuilder tempActors = new StringBuilder();
            for (int i = 0; i < Actors.Count; i++)
            {
                tempActors.Append(Actors[i]);
                tempActors.Append(" ,");
            }
            return tempActors.ToString();

        }
    }
}
