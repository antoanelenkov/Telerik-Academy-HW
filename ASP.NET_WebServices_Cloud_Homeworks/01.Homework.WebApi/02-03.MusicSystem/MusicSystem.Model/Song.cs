using System.ComponentModel.DataAnnotations;

namespace MusicSystem.Model
{
    public class Song
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public int Year { get; set; }

        public string  Genre { get; set; }

        public virtual int ArtistId { get; set; }

        public virtual Artist   Artist { get; set; }
    }
}
