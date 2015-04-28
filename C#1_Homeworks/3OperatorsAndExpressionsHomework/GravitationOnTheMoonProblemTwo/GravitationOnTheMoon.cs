using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

namespace GravitationOnTheMoonProblemTwo
{
    class GravitationOnTheMoon
    {
        static void Main(string[] args)
        {
            double weigthOnTheEarth = 252;
            double weigthOnTheMoon = 17 * weigthOnTheEarth / 100 + 17 % weigthOnTheEarth / 100;
            Console.WriteLine(weigthOnTheMoon);
        }
    }
}
