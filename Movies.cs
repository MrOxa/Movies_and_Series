using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Movies_and_Series
{
    public class Movie
    {
        public string Name { 
            get { return Name; }
            set 
            {
                if (value == null)
                {
                    throw new NoNullAllowedException();
                }
            }
        }
        public int Year
        {
            get { return Year; }
            set
            {
                if (value == 0)
                {
                    throw new NoNullAllowedException();
                }
            }
        }
        
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
