using System;
using System.IO;
using System.Text;

/*•	Write a program that compares two text files line by line and prints the number of
 *  lines that are the same and the number of lines that are different.
  •	Assume the files have equal number of lines.*/

class CompareTextFiles
{
    static void Main()
    {
        var readerOne = new StreamReader("test.txt", Encoding.GetEncoding("Windows-1251"));
        var readerTwo = new StreamReader("test2.txt", Encoding.GetEncoding("Windows-1251"));
        using (readerOne)
        {
            int sameCount = 0;
            int differentCount = 0;
            string lineOne = readerOne.ReadLine();
            using (readerTwo)
            {
                string lineTwo = readerTwo.ReadLine();
                while (lineOne != null)
                {
                    if (lineOne == lineTwo)
                    {
                        sameCount++;
                    }
                    else
                    {
                        differentCount++;
                    }
                    lineOne = readerOne.ReadLine();
                    lineTwo = readerTwo.ReadLine();
                }
                Console.WriteLine("The same lines are {0} and the different lines are {1}",sameCount,differentCount);
            }
        }

    }
}

