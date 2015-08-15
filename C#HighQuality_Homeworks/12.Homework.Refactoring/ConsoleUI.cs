using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixTask
{
    public class ConsoleUI : IPrinter, IReader
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }

        public void Read()
        {
            throw new NotImplementedException();
        }
    }
}
