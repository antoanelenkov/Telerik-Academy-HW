namespace PrintStatistic
{
    using System;

    public class StatisticsPrinter
    {
        private double[] numbers;

        public StatisticsPrinter(double[] arr)
        {
            this.numbers = arr;
        }

        public void PrintMin(int numberOfElements)
        {
            Console.WriteLine(this.GetMinElementInRange(numberOfElements));
        }

        public void PrintMax(int numberOfElements)
        {
            Console.WriteLine(this.GetMaxElementInRange(numberOfElements));
        }

        public void PrintAverage(int numberOfElements)
        {
            Console.WriteLine(this.GetAverageInRange(numberOfElements));
        }

        private double GetMaxElementInRange(int numberOfElements)
        {
            var max = double.MinValue;
            for (int i = 0; i < numberOfElements; i++)
            {
                if (this.numbers[i] > max)
                {
                    max = this.numbers[i];
                }
            }

            return max;
        }

        private double GetMinElementInRange(int numberOfElements)
        {
            var min = double.MaxValue;
            for (int i = 0; i < numberOfElements; i++)
            {
                if (this.numbers[i] < min)
                {
                    min = this.numbers[i];
                }
            }

            return min;
        }

        private double GetAverageInRange(int numberOfElements)
        {
            double sum = 0;
            for (int i = 0; i < numberOfElements; i++)
            {
                sum += this.numbers[i];
            }

            var average = sum / numberOfElements;

            return average;
        }
    }
}
