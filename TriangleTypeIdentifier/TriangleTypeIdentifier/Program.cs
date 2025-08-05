using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.WriteLine("Enter the lengths of the three sides of the triangle:");

        Console.Write("Side A: ");
        double sideA = Convert.ToDouble(Console.ReadLine());

        Console.Write("Side B: ");
        double sideB = Convert.ToDouble(Console.ReadLine());

        Console.Write("Side C: ");
        double sideC = Convert.ToDouble(Console.ReadLine());

        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            Console.WriteLine("Sides must be positive numbers.");
        }
        else if (sideA == sideB && sideB == sideC)
        {
            Console.WriteLine("The triangle is Equilateral.");
        }
        else if (sideA == sideB || sideA == sideC || sideB == sideC)
        {
            Console.WriteLine("The triangle is Isosceles.");
        }
        else
        {
            Console.WriteLine("The triangle is Scalene.");
        }
    }
}
