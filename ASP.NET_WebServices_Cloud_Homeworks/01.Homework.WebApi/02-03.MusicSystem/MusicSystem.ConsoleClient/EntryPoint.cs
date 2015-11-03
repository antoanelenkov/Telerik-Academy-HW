using MusicSystem.Data;
using System.Linq;

namespace MusicSystem.ConsoleClient
{
    class EntryPoint
    {
        static void Main()
        {
            var db = new MusicSystemDbContext();

            System.Console.WriteLine(db.Albums.Count());
        }
    }
}
