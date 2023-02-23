using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Gamer
    {

        public string Name { get; set; }

        public string Sport { get; set; }

        public int year { get; set; }

        public string VideoGameName
        {

            get 
            { 
                return $"{Name} {Sport}";
            }

        }

    }
}
