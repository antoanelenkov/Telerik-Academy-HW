namespace _01.Courses
{
    using System;
    using Wintellect.PowerCollections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class EntryPoint
    {
        static void Main()
        {
            var text = @"Kiril  | Ivanov   | C#
                        Stefka | Nikolova | SQL
                        Stela  | Mineva   | Java
                        Milena | Petrova  | C#
                        Ivan   | Grigorov | C#
                        Ivan   | Antonov | C#
                        Anton   | Ivanov | C#
                        Anton   | Antonov | C#
                        Ivan   | Kolev    | SQL";

            var splittedWords = text.Split(new char[] { '|', ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            var courses = new SortedDictionary<string, OrderedBag<Student>>();
            var count = 0;

            for (int i = 0; i < splittedWords.Length; i++)
            {


                if (++count % 3 == 0)
                {
                    var course = splittedWords[i];
                    var lastName = splittedWords[i - 1];
                    var firstName = splittedWords[i - 2];

                    if (!courses.ContainsKey(course))
                    {
                        courses.Add(course, new OrderedBag<Student>());
                    }
                    courses[course].Add(new Student(firstName, lastName));
                }
            }

            foreach (var course in courses)
            {
                Console.WriteLine("Name of the course: " + course.Key);
                foreach (var student in course.Value)
                {

                    Console.WriteLine("Name of the student: " + student.FirstName + " " + student.LastName);
                }
                Console.WriteLine();
            }

        }
    }
}
