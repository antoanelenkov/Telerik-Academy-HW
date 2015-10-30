using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new MyQueue<int>(1);
            var queu2 = new Queue<int>();
            
            queue.Enqueue(3);
            queue.Enqueue(5);
            queue.Enqueue(4);
            System.Console.WriteLine(queue.Peek());
            System.Console.WriteLine(queue.Dequeue());
            System.Console.WriteLine(queue.Dequeue());

        }
    }
}
