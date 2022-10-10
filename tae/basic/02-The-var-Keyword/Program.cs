// A variable can be explicitly declared with its type before it is used.
// Alternatively, C# provides a handy function to enable the compiler to determine the type of the variable automatically based on the expression it is assigned to.
// Variables declared using the var keyword are called implicitly typed variables.
// Implicitly typed variables must be initialized with a value.

using System;

namespace _02_The_var_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("do not overuse var!");
        }
    }
}