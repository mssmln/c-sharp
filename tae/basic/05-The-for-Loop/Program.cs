// The init and increment statements may be left out, if not needed, but remember that the semicolons are mandatory.
// You can have the increment statement in the for loop body:
// for (; ; ) { } is an infinite loop.

using System;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            for (; x > 0;)
            {
                Console.WriteLine(x);
                x -= 3;
            }
        }
    }
}