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
        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }
        public int Year
        {
            get { return Year; }
            set { Year = value; }
        }
        public List<string> Actors { get; set; } = new List<string>();
        public string Description { get; set; }

        public Movie(string Name, int Year, string Description, params string[] Actors)
        {
            this.Name = Name;
            this.Year = Year;
            this.Description = Description;
            for (int i = 0; i < Actors.Length; i++)
            {
                this.Actors.Add(Actors[i]);
            }
        }
    }
}
