using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Declare two string variables and assign them with Hello and World.
//Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
//Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

namespace StringsAndObjectsProblemSix
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string firstWord = "Hello";
            string secondWord = "World";
            object sentenceOne = firstWord + " " + secondWord;
            string objectToString = sentenceOne+"";
            Console.WriteLine(sentenceOne);
            Console.WriteLine(objectToString);


        }
    }
}
