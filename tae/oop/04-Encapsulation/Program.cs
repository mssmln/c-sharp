// Part of the meaning of the word encapsulation is the idea of "surrounding" an entity, not just to keep what's inside together, but also to protect it.
// In programming, encapsulation means more than simply combining members together within a class; it also means restricting access to the inner workings of that class.
// Encapsulation is implemented by using access modifiers. An access modifier defines the scope and visibility of a class member.
// Encapsulation is also called information hiding.

// C# supports the following access modifiers: public, private, protected, internal, protected internal.
// As seen in the previous examples, the public access modifier makes the member accessible from the outside of the class.
// The private access modifier makes members accessible only from within the class and hides them from the outside.

// In summary, the benefits of encapsulation are:
// Control the way data is accessed or modified.
// Code is more flexible and easy to change with new requirements.
// Change one part of code without affecting other parts of code.


// We are developing a profile system for player of our online game.
// The program already takes the number of games and wins as input and creates a player object.
// Complete the GetWinRate() method inside the given Player class to calculate and output the win rate.

using System;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int games = Convert.ToInt32(Console.ReadLine());
            int wins = Convert.ToInt32(Console.ReadLine());
            Player player1 = new Player();
            player1.games = games;
            player1.wins = wins;
            player1.GetWinRate();
        }
    }
    class Player
    {
        public int games;
        public int wins;
        private int winrate;
        public void GetWinRate()
        {
            winrate = wins * 100 / games;
            Console.Write(winrate);
        }
    }
}