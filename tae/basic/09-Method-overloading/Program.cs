// Method overloading is when multiple methods have the same name, but different parameters.
// When overloading methods, the definitions of the methods must differ from each other by the types and/or number of parameters.
// When there are overloaded methods, the method called is based on the arguments. An integer argument will call the method implementation that accepts an integer parameter. A double argument will call the implementation that accepts a double parameter. Multiple arguments will call the implementation that accepts the same number of arguments.
// You cannot overload method declarations that differ only by return type.

using System;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(10, 12));
            Console.WriteLine(Add(1.5, 2.9));
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static double Add(double a, double b)
        {
            return a + b;
        }
    }
}