// A jagged array is an array whose elements are arrays. So it is basically an array of arrays.
// The following is a declaration of a single-dimensional array that has three elements, each of which is a single-dimensional array of integers:
// int[][] jaggedArr = new int[3][];

// Each dimension is an array, so you can also initialize the array upon declaration like this:
// int[][] jaggedArr = new int[][]
// {
// new int[ ] {1,8,2,7,9},
// new int[ ] {2,4,6},
// new int[ ] {33,42}
// };

// A jagged array is an array-of-arrays, so an int[ ][ ] is an array of int[], each of which can be of different lengths and occupy their own block in memory.
// A multidimensional array (int[,]) is a single block of memory (essentially a matrix). It always has the same amount of columns for every row.

// jagged array that contains 8 two-dimensional arrays.
// int[][,] a = new int[8][,];


// Write a program to take the numbers of each day's winners as input and output them.
using System;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int day1Winner = Convert.ToInt32(Console.ReadLine());
            int day2Winner = Convert.ToInt32(Console.ReadLine());
            int day3Winner = Convert.ToInt32(Console.ReadLine());
            string[][] olympiad = new string[][]
            {
                //day 1 - 5 participants
                new string[] { "Jill Yan", "Bridgette Ramona", "Sree Sanda", "Jareth Charlene", "Carl Soner" },
                //day 2 - 7 participants
                new string[] { "Anna Hel", "Mariette Vedrana", "Fran Mayur", "Drake Hilmar", "Nikolay Brooks", "Eliana Vlatko", "Villem Mario" },
                //day 3 - 4 participants
                new string[] { "Hieremias Zavia", "Ziya Ollie", "Christoffel Casper", "Kristian Dana", }
            };
            Console.WriteLine(olympiad[0][day1Winner - 1]);
            Console.WriteLine(olympiad[1][day2Winner - 1]);
            Console.WriteLine(olympiad[2][day3Winner - 1]);
        }
    }
}