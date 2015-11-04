namespace MusicSystem.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Album
    {
        private ICollection<Artist> artists;

        public Album()
        {
            this.artists = new HashSet<Artist>();
        }

        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public int Year { get; set; }

        public string Prdoucer { get; set; }


        public ICollection<Artist>  Artists
        {
            get { return this.artists; }
            set { this.artists = value; }
        }
    }
}
