namespace MusicSystem.ConsoleClient
{
    using Data;
    using System.Linq;

    class EntryPoint
    {
        static void Main()
        {
            var db = new MusicSystemData();

            System.Console.WriteLine(db.Albums.All().Count());
        }
    }
}
