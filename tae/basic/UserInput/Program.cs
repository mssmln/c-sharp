// The Console.ReadLine() method returns a string value.
// If you are expecting another type of value (such as int or double), the entered data must be converted to that type.
// For integer conversion, there are three alternatives available based on the bit size of the integer: Convert.ToInt16, Convert.ToInt32 and Convert.ToInt64. The default int type in C# is 32-bit.

using System;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are {0} years old", age);
        }
    }
}