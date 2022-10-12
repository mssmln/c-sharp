// the Length and Rank properties return the number of elements and the number of dimensions of the array, respectively. You can access them using the dot syntax

// Write a program to take 5 numbers as input, then calculate and output the sum of the maximum and the minimum inputted values.
using System;
using System.Linq;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            int[] a = new int[5];
            while (c < 5)
            {
                a[c] = Convert.ToInt32(Console.ReadLine());
                c++;
            }
            Console.Write(a.Max() + a.Min());
        }
    }
}