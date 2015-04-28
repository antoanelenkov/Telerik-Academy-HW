using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program that reads the radius r of a circle 
//and prints its perimeter and area formatted with 2 digits after the decimal point.

namespace ProblemThree
{
    class CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for radius's lenght:");
            double radius = double.Parse(Console.ReadLine());
            double perimeter = radius * Math.PI * 2;
            double area = Math.Pow(radius, 2) * Math.PI;
            Console.WriteLine("The area of the circle is:{0:F2}\nThe perimeter of the circle is:{1:F2}", area, perimeter);
        }
    }
}
