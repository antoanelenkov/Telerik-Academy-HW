using MusicSystem.Data;
using System.Linq;

namespace MusicSystem.ConsoleClient
{
    class EntryPoint
    {
        static void Main()
        {
            var db = new MusicSystemData();

            System.Console.WriteLine(db.Albums.All().Count());
        }
    }
}
