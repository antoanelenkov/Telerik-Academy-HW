using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
Use LINQ query operators.*/

namespace _03.FirstBeforeLast
{
    class FirstName
    {
        static void Main()
        {
            List<Students> allNames = new List<Students>()
            {
            new Students("Petar","Borisov",22),
            new Students("Petar","Angelov",25),
            new Students("Petar","Petrov",21),
            new Students("Georgi","Ivanov",12),
            new Students("Baba","Qga",18),
            new Students("Dqdo","Koleda",36),
            new Students("Chicho","Skruch",20),
            };

            //Problem 3 - Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
            var orderedNames =
                from names in allNames
                where names.FirstName.CompareTo(names.LastName) < 0
                select names;
            //Second way of solving the same problem
            var orderedNames2 = allNames
                .Where(names => names.FirstName.CompareTo(names.LastName) < 0)
                .Select(names => names);
            Console.WriteLine("3.The names ordered alphabetically:");
            Console.WriteLine(String.Join(Environment.NewLine, orderedNames));
            Console.WriteLine("\n3.Result from the second way of sloving the problem:");
            Console.WriteLine(String.Join(Environment.NewLine, orderedNames2));

            //Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
            var resultFromAge = allNames
                .Where(names => names.Age < 24 && names.Age > 18)
                .Select(names => names);
            Console.WriteLine("\n4.The people in the range of 18 to 24 years old:");
            Console.WriteLine(String.Join(Environment.NewLine, resultFromAge));

            /*Using the extension methods OrderBy() and ThenBy() with lambda expressions 
             * sort the students by first name and last name in descending order.
            Rewrite the same with LINQ.*/
            var resultFromSorting = allNames
                .OrderByDescending(names => names.FirstName)
                .ThenBy(names => names.LastName);
            Console.WriteLine("\n5.The names ordered by first and  after that by last name:");
            Console.WriteLine(String.Join(Environment.NewLine, resultFromSorting));
            var resultFromSorting2 =
                from name in allNames
                orderby name.FirstName descending, name.LastName descending 
                select name;
            Console.WriteLine("\n5.The names ordered by first and  after that by last name(LINQ):");
            Console.WriteLine(String.Join(Environment.NewLine, resultFromSorting2));

            //Console.WriteLine("Afd".CompareTo("Asd"));
        }
    }
}
