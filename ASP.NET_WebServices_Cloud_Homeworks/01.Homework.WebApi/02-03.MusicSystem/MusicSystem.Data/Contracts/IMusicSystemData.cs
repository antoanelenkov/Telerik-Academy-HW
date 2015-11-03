using MusicSystem.Model;
using System;

namespace MusicSystem.Data.Contracts
{
    public interface IMusicSystemData:IDisposable
    {
        IGenericRepository<Artist> Artists { get; }

        IGenericRepository<Album> Albums { get; }

        IGenericRepository<Song> Songs { get; }

        int SaveChanges();
    }
}
