// As constructors are used when a class is instantiated, destructors are automatically invoked when an object is destroyed or deleted.
// Destructors have the following attributes:
// A class can only have one destructor.
// Destructors cannot be called. They are invoked automatically.
// A destructor does not take modifiers or have parameters.
// The name of a destructor is exactly the same as the class prefixed with a tilde (~).
// Destructors can be very useful for releasing resources before coming out of the program. This can include closing files, releasing memory, and so on.
// When the program runs, it first creates the object, which calls the constructor. The object is deleted at the end of the program and the destructor is invoked when the program's execution is complete.
// This can be useful, for example, if your class is working with storage or files. The constructor would initialize and open the files. Then, when the program ends, the destructor would close the files.


// Complete the FinalRound class by writing the needed code in constructor to take the array and the winner index as parameters and output the corresponding message to show the winner. Then create a destructor to finish the game and output "Game Over".
using System;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] finalists = { "James Van", "John Smith", "Leyla Brown", "Tom Homerton", "Bob Douglas" };
            int winner = Convert.ToInt32(Console.ReadLine());
            FinalRound finalRound = new FinalRound(finalists, winner);
        }
    }
    class FinalRound
    {
        public FinalRound(string[] finalists, int winner)
        {
            Console.WriteLine("Winner is " + finalists[winner]);
        }
        ~FinalRound()
        {
            Console.WriteLine("Game Over");
        }
    }
}