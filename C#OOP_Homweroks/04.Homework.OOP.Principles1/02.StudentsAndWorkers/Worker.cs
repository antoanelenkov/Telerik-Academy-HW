using System;

namespace StudentsAndWorkers
{
    class Worker : Human
    {
        private decimal weekSalary;
        private float hoursPerWeek;

        public Worker(string first, string last, decimal salary, float hours)
            : base(first, last)
        {
            WeekSalary = salary;
            HoursPerWeek = hours;
        }

        public float HoursPerWeek
        {
            get { return hoursPerWeek; }
            set {
                if (value <= 0)
                {
                    throw new IndexOutOfRangeException("The working hours must be more than 0.");
                }
                else
                {
                    hoursPerWeek = value; 
                }

            }
        }      
        public decimal WeekSalary
        {
            get { return weekSalary; }
            set
            {
                if (value < 1000)
                {
                    throw new IndexOutOfRangeException("Don't fuck with the workers. Give them more money!!!");
                }
                else
                {
                    weekSalary = value;
                }
            }
        }

        public decimal CalculateMoneyPerHour()
        {
            return (decimal)this.WeekSalary / (decimal)this.HoursPerWeek;
        }

    }
}
