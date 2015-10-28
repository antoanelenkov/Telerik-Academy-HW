using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoAcademy.BadNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfHouses = int.Parse(Console.ReadLine());
            var evenMoney = new List<int>();
            var oddMoney = new List<int>();


            for (int i = 0; i < numberOfHouses; i++)
            {
                if (numberOfHouses % 2 != 0 && i ==numberOfHouses-1)
                {
                    continue;
                }

                if (i % 2 == 0)
                {
                    evenMoney.Add(int.Parse(Console.ReadLine()));
                }
                else
                {
                    oddMoney.Add(int.Parse(Console.ReadLine()));
                }
            }

            var oddSum = 0;
            var evenSum = 0;
            evenMoney.ForEach(y => evenSum += y);
            oddMoney.ForEach(y => oddSum += y);

            Console.WriteLine(oddSum>evenSum?oddSum:evenSum);
        }
    }
}
