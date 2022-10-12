// A multidimensional array is declared as follows:
// type[, , … ,] arrayName = new type[size1, size2, …, sizeN];


// Complete the program to output this array in the form of a table (without separation)
using System;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] num = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(num[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}