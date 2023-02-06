using System;

namespace pythagorathTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of side A: ");
            double sideA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the length of side B: ");
            double sideB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter amount of angle between A and B in degrees: ");
            double degree = Convert.ToDouble(Console.ReadLine());
        }
    }
}
