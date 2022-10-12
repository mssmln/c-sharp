// We can provide initial values to the array when it is declared by using curly brackets:
// string[] names = new string[3] { "John", "Mary", "Jessica" };
// We can omit the size declaration when the number of elements are provided in the curly braces:
// string[] names = new string[] { "John", "Mary", "Jessica" };
// We can even omit the new operator. The following statements are identical to the ones above:
// string[] names = {"John", "Mary", "Jessica"};

// Write a program to take N number as input and output the corresponding game with N index from the array.
// If user enters an invalid number that is out of array range, the program should output "Invalid number".

using System;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] games = { "Alien Shooter", "Tic Tac Toe", "Snake", "Puzzle", "Football" };
            try
            {
                Console.WriteLine(games[Int32.Parse(Console.ReadLine())]);
            }
            catch
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
}