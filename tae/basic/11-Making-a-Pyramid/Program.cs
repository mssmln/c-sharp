// 1.The first row should contain one star at the top center of the pyramid. The center is calculated based on the number of rows in the pyramid.
// 2. Each row after the first should contain an odd number of stars (1, 3, 5, etc.), until the number of rows is reached.

using System;

namespace SoloLearn
{
    class Program
    {
        static void DrawPyramid(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            DrawPyramid(50);
        }
    }
}