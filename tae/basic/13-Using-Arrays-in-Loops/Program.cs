// The data type of the variable in the foreach loop should match the type of the array elements.
// Often the keyword var is used as the type of the variable, as in: foreach (var k in a).The compiler determines the appropriate type for var.

using System;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int count = 0;
            while (count < 5)
            {
                numbers[count] = Convert.ToInt32(Console.ReadLine());
                count++;
            }
            int sum = 0;
            foreach (var n in numbers)
            {
                if (n % 2 == 0)
                {
                    sum += n;
                }
            }
            Console.Write(sum);
        }
    }
}