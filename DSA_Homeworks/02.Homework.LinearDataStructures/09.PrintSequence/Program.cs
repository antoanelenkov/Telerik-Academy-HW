using System;
using System.Collections.Generic;
using System.Linq;

/*  Дадена е следната поредица:
S1 = N;
S2 = S1 + 1;
S3 = 2*S1 + 1;
S4 = S1 + 2;
S5 = S2 + 1;
S6 = 2*S2 + 1;
S7 = S2 + 2;
...
Използвайки класа Queue<T> напишете програма, която по дадено N отпечатва на конзолата първите 50 числа от тази поредица.
Пример: N=2 à 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...*/

namespace _09.PrintSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var loops = 50;
            int startNumber = 2;
            Queue<int> sequenceConstructor = new Queue<int>();

            sequenceConstructor.Enqueue(startNumber);
            for (int i = 0; i < loops; i++)
            {
                sequenceConstructor.Enqueue(sequenceConstructor.First()+1);
                sequenceConstructor.Enqueue(sequenceConstructor.First() * 2 + 1);
                sequenceConstructor.Enqueue(sequenceConstructor.First() + 2);
                Console.WriteLine(sequenceConstructor.Dequeue());
            }
        }
    }
}
