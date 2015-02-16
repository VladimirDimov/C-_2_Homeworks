//  Problem 4. Triangle surface
//  ===========================
//  Write methods that calculate the surface of a triangle by given:
//  Side and an altitude to it;
//  Three sides;
//  Two sides and an angle between them;
//  Use System.Math.
//  =================================================================

using System;

class TriangleSurface
{
    static void Main()
    {
        int option;
        double surface;

        Console.WriteLine("******************MENU******************");
        Console.WriteLine("1    Side and an altitude to it");
        Console.WriteLine("2    Three sides");
        Console.WriteLine("3    Two sides and an angle between them");
        Console.WriteLine("****************************************");
        Console.WriteLine();
        Console.Write("Enter an option from the above menu: ");
        option = int.Parse(Console.ReadLine());

        if (option == 1)
        {
            Console.Write("Enter side length: ");
            double side = double.Parse(Console.ReadLine());

            Console.Write("Enter altitude length: ");
            double altitude = double.Parse(Console.ReadLine());

            surface = SurfaceBySideAndAltitude(side, altitude);
        }
        else if (option == 2)
        {
            Console.Write("Enter first side length: ");
            double firstSide = double.Parse(Console.ReadLine());

            Console.Write("Enter second side length: ");
            double secondSide = double.Parse(Console.ReadLine());

            Console.Write("Enter third side length: ");
            double thirdSide = double.Parse(Console.ReadLine());

            surface = SurfaceByThreeSides(firstSide, secondSide, thirdSide); 
        }
        else if (option == 3)
        {
            Console.Write("Enter first side length: ");
            double firstSide = double.Parse(Console.ReadLine());

            Console.Write("Enter second side length: ");
            double secondSide = double.Parse(Console.ReadLine());

            Console.Write("Enter angle: ");
            double angle = double.Parse(Console.ReadLine());

            surface = SurfaceByThoSidesAndAngle(firstSide, secondSide, angle);
        }
        else
        {
            Console.WriteLine("Invalid option");
            return;
        }
        Console.WriteLine("The triangle surface is {0}", surface);
    }

    static double SurfaceBySideAndAltitude(double side, double altitude)
    {
        return side * altitude / 2;
    }

    static double SurfaceByThreeSides(double firstSide, double secondSide, double thirdSide)
    {
        double semiperimeter = (firstSide + secondSide + thirdSide) / 2;
        return Math.Sqrt(semiperimeter * (semiperimeter - firstSide) * (semiperimeter - secondSide) * (semiperimeter - thirdSide));    
    }

    static double SurfaceByThoSidesAndAngle(double firstSide, double secondSide, double angle)
    {
        return firstSide * secondSide * Math.Sin(angle*Math.PI / 180) / 2;
    }
}
