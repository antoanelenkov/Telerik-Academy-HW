namespace People
{
    using People.Classes;

    public class Program
    {
        public static void Main()
        {
            var personCreator = new PersonCreater();

            personCreator.MakePerson(15);
        }
    }
}
