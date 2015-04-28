using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Test
    {
        static void Main(string[] args)
        {
            var listtt = new List<int>();            
            GenericList<int> myList = new GenericList<int>(10);
            //ADD
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            Console.WriteLine(myList.ToString());
            Console.WriteLine("Insert element");
            //INSERT AT GIVEN POSITION
            myList.Insert(3, 50);
            myList.Insert(3, 60);
            Console.WriteLine(myList.ToString());
            Console.WriteLine("Find element:");
            //FIND CERTAINT ELEMENT AT WHAT INDEXES EXISTS
            myList.Find(25);
            Console.WriteLine("Remove element:");
            //REMOVE AT CERTAIN INDEX
            myList.Remove(2);
            Console.WriteLine(myList.ToString());
            Console.WriteLine("Find maximum");
            //FIND MAX
            Console.WriteLine(myList.Max());
            Console.WriteLine("Find minimum");
            //FIND MIN
            Console.WriteLine(myList.Max());
            //CLEAR ALL
            Console.WriteLine("Clear all");
            myList.Clear();
            Console.WriteLine(myList.ToString());
        }
    }
}
