// An entire class can be declared as static.
// A static class can contain only static members.
// You cannot instantiate an object of a static class, as only one instance of the static class can exist in a program.
// Static classes are useful for combining logical properties and methods.A good example of this is the Math class.

// The Console class is also an example of a static class. We use its static WriteLine() method to output to the screen, or the static ReadLine() method to get user input.
// The Convert class used to convert value types is also a static class.


// Complete the program to sort and output every element of an array, each on a new line.
using System;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(numbers);
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}