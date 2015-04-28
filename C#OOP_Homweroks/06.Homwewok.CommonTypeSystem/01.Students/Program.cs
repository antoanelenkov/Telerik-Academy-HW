using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            var Antoan = new Student("Antoan", "Petrov", "Elenkov", 14690, "Sin City", "+12345678",
                "antoan@abv.bg", 5, Specialitiy.CivilEngineering, University.UACG, Faculty.Mathematic);
            var Antoan2 = new Student("Antoan", "Petrov", "Elenkov", 14690, "Sin City", "+12345678",
                "antoan@abv.bg", 5, Specialitiy.CivilEngineering, University.UACG, Faculty.Mathematic);
            Console.WriteLine(Antoan.ToString());

            Console.WriteLine("\nChecks if getHashCode() is implemented properly:");
            Console.WriteLine(Antoan.GetHashCode());
            Console.WriteLine(Antoan2.GetHashCode());

            //2.IClonable - Clone Object
            Console.WriteLine("\nThis is the deep copy:");
            var AntoanCopy = Antoan.Clone();
            Console.WriteLine(AntoanCopy);

            //3.Implement the IComparable<Student> interface to compare students by names (as first criteria, 
            //in lexicographic order) and by social security number (as second criteria, in increasing order).
            Console.WriteLine("\nCompare student Antoan with his copy:");
            Console.WriteLine(Antoan.CompareTo(Antoan2));
        }
    }
}
