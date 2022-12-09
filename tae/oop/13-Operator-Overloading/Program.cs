// Most operators in C# can be overloaded, meaning they can be redefined for custom actions.
// For example, you can redefine the action of the plus (+) operator in a custom class.
// Overloaded operators are methods with special names, where the keyword operator is followed by the symbol for the operator being defined.
// Similar to any other method, an overloaded operator has a return type and a parameter list.
// Additionally, the overloaded operator must be static.
// All arithmetic and comparison operators can be overloaded. For instance, you could define greater than and less than operators for the boxes that would compare the Boxes and return a boolean result. Just keep in mind that when overloading the greater than operator, the less than operator should also be defined.

// You and your friend are playing a game as one team. Each player must pass 2 rounds and gets points for each round passed.
// The program you are given creates two Score objects where each round scores are stored (they are passed to a constructor).
// Overload the + operator for the Score class to calculate the team score for every round.

using System;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Score tm1 = new Score(2, 3);
            Score tm2 = new Score(4, 2);
            Score finalScores = tm1 + tm2;

            Console.WriteLine("Round 1: " + finalScores.round1Score);
            Console.WriteLine("Round 2: " + finalScores.round2Score);
        }
    }
    class Score
    {
        public int round1Score { get; set; }
        public int round2Score { get; set; }
        public Score(int r1, int r2)
        {
            round1Score = r1;
            round2Score = r2;
        }
        public static Score operator + (Score a, Score b)
        {
            int h = a.round1Score + b.round1Score;
            int w = a.round2Score + b.round2Score;
            Score res = new Score(h, w);
            return res;
        }
    }
}