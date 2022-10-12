// When you declare a string variable, you basically instantiate an object of type String.


// Write a program to output "Invalid", if it contains any disallowed symbols.
// If the password requirement is satisfied, program shouldn't output anything.
using System;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            char[] notAllowedSymbols = { '!', '#', '$', '%', '&', '(', ')', '*', ',', '+', '-' };
            if (password.IndexOfAny(notAllowedSymbols) != -1)
                Console.Write("Invalid");
        }
    }
}