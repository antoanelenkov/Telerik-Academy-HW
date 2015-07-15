using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contintents.Models
{
    public class Town
    {
        public int TownID { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }

        public int CountryID { get; set; }
        public virtual Country Country { get; set; }

        static void Main(string[] args)
        {
            //do nothing
        }
    }
}
