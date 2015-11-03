using System;
using System.Collections.Generic;

namespace MusicSystem.Model
{
    //Artists (Name, Country, DateOfBirth, etc.)
    public class Artist
    {
        private ICollection<Song> songs;

        public Artist()
        {
            this.songs = new HashSet<Song>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string  Country { get; set; }

        public DateTime DateOfBirth { get; set; }

        public ICollection<Song> Songs
        {
            get { return this.songs; }
            set { this.songs = value; }
        }
    }
}
