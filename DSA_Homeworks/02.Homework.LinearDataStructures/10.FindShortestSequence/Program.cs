namespace FindShortestSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        /*We are given numbers N and M and the following operations:
        N = N+1
        N = N+2
        N = N*2    
         * 
        Write a program that finds the shortest sequence of operations from the list above that starts from N and finishes in M.
         * 
        Hint: use a queue.
        Example: N = 5, M = 16
        Sequence: 5 → 7 → 8 → 16*/

        static void Main()
        {
            Console.Write("Enter sequence start: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter sequence end: ");
            int m = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();
            stack.Push(m);
            while (m / 2 >= n)
            {
                m = m / 2;
                stack.Push(m);
            }

            while (m - 2 >= n)
            {
                m = m - 2;
                stack.Push(m);
            }

            while (m - 3 >= n)
            {
                m = m - 1;
                stack.Push(m);
            }

            Console.WriteLine(string.Join(" -> ", stack));
        }
    }
}
