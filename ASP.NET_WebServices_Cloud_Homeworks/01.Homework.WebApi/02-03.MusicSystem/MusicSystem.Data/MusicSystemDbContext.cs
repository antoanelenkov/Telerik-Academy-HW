namespace MusicSystem.Data
{
    using MusicSystem.Data.Contracts;
    using MusicSystem.Data.Migrations;
    using MusicSystem.Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MusicSystemDbContext : DbContext
    {
        public MusicSystemDbContext()
            : base("MusicSystemDb")
        {
            new MigrateDatabaseToLatestVersion<MusicSystemDbContext, Configuration>();
        }

        public IDbSet<Artist> Artists { get; set; }

        public IDbSet<Song> Songs { get; set; }

        public IDbSet<Album> Albums { get; set; }
    }
}
