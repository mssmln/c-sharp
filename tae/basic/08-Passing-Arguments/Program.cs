// There are three ways to pass arguments to a method when the method is called: By value, By reference, and as Output.

using System;

namespace SoloLearn
{
    class Program
    {
        // By value copies the argument's value into the method's formal parameter. Here, we can make changes to the parameter within the method without having any effect on the argument.
        // By default, C# uses call by value to pass arguments.
        // The following example demonstrates by value:
        // As you can see, the Sqr method does not change the original value of the variable, as it is passed by value, meaning that it operates on the value, not the actual variable.
        static void Sqr(int x)
        {
            x = x * x;
        }

        // Pass by reference copies an argument's memory address into the formal parameter. Inside the method, the address is used to access the actual argument used in the call. This means that changes made to the parameter affect the argument.
        // To pass the value by reference, the ref keyword is used in both the call and the method definition:
        // The ref keyword passes the memory address to the method parameter, which allows the method to operate on the actual variable.
        static void Sqr1(ref int x)
        {
            x = x * x;
        }

        // Output parameters are similar to reference parameters, except that they transfer data out of the method rather than accept data in. They are defined using the out keyword.
        // The variable supplied for the output parameter need not be initialized since that value will not be used.Output parameters are particularly useful when you need to return multiple values from a method.
        static void GetValues(out int x, out int y)
        {
            x = 5;
            y = 42;
        }
        static void Main(string[] args)
        {
            int a = 3;
            Sqr(a);
            Console.WriteLine(a);

            int b = 3;
            Sqr1(ref b);
            Console.WriteLine(b);

            int c, d;
            GetValues(out c, out d);
            Console.WriteLine(c + " " + d);
        }
    }
}