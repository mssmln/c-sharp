// Write a program to take N number as input and recursively calculate the sum of all numbers from 1 to N.

using System;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Sum(number));
        }
        static int Sum(int num)
        {
            return num == 1 ? 1 : num + Sum(num - 1);
        }
    }
}