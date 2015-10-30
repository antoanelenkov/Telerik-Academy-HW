using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stackche = new Stack<int>();

            //stackche.Pop();


            var stack=new MyStack<int>(1);

            stack.Push(3);
            stack.Push(5);
            stack.Push(4);
            System.Console.WriteLine(stack.Peek());
            System.Console.WriteLine(stack.Pop());
            System.Console.WriteLine(stack.Pop());

        }

    }
}
