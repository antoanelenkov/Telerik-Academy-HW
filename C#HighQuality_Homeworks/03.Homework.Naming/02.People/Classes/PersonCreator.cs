namespace People.Classes
{
    public class PersonCreater
    {
        public void MakePerson(int age)
        {
            Person person1 = new Person();
            person1.Age = age;

            if (age % 2 == 0)
            {
                person1.Name = "The batka";
                person1.Sex = Sex.male;
            }
            else
            {
                person1.Name = "The kifla";
                person1.Sex = Sex.female;
            }
        }   
    }
}
