// Complete the program to take the radius as input, then calculate and output the area of the circle.

using System;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double radius;
            radius = Convert.ToDouble(Console.ReadLine());
            Console.Write(pi * radius * radius);
        }
    }
}