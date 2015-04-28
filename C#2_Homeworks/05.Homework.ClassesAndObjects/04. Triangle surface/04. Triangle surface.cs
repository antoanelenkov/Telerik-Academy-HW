using System;

/*•	Write methods that calculate the surface of a triangle by given:
    o	Side and an altitude to it;
    o	Three sides;
    o	Two sides and an angle between them;
  •	Use System.Math.*/

class TriangleSurface
{
    static void Main()
    {
        double A = 3;
        double B = 5.196;
        double C = 6;
        double angle = 30;

        Console.WriteLine("{0:F2}", CalculateSurface(A, B, C));
        Console.WriteLine("{0:F2}", CalculateSurfaceByAngle(A, B,angle));
        Console.WriteLine("{0:F2}", CalculateSurface(A, B));
    }

    static double CalculateSurface(double side, double altitude)
    {
        double surface = (side * altitude) / 2;
        return surface;
    }

    static double CalculateSurface(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        double surface = Math.Pow((p * (p - a) * (p - b) * (p - c)), 0.5);
        return surface;
    }

    static double CalculateSurfaceByAngle(double a, double b, double x)
    {
        double angleinRadians = Math.PI * x /180;
        double surface = a * b * Math.Sin(angleinRadians);
        return surface;
    }

}


