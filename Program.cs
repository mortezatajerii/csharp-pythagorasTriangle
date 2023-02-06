using System;

namespace pythagorasTriangle
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
            degree = degree * Math.PI / 180.0;

            // * Calculation >>

            double result;
            result = Math.Pow(sideA, 2) + Math.Pow(sideB, 2) - 2 * sideA * sideB * Math.Cos(degree);
            result = Math.Sqrt(result);

            Console.WriteLine($"Side C is equal to {Math.Round(result,2)}");
        }
    }
}
