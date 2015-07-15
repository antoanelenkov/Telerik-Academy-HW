using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contintents.Models
{
    public class Country
    {
        private IEnumerable<Town> towns;

        public Country()
        {         
            this.towns = new HashSet<Town>();
        }

        public int CountryID { get; set; }
        public string Name { get; set; }
        public int population { get; set; }

        public int ContinentId { get; set; }
        public virtual Continent Continent { get; set; }

        public IEnumerable<Town> Towns
        {
            get
            {
                return this.towns;
            }
            set
            {
                this.towns = value;
            }
        }
    }
}
