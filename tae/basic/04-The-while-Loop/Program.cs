// We can shorten the while, by incrementing the value of num right in the condition:
// What do you think, is there a difference between while(num++ < 6) and while (++num < 6)?
// Yes! The loop while (++num < 6) will execute 5 times, because pre-increment increases the value of x before checking the num < 6 condition, while post-increment will check the condition before increasing the value of num, making while(num++ < 6) execute 6 times.

using System;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while (++num < 6)
                Console.WriteLine(num);
        }
    }
}