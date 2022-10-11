// A store is running a promotion: if the total purchase price is equal to or exceeds
// 10000, the price will be discounted by 20%.
// The program you are given takes the total purchase price as input.
// Complete the given method to take the total purchase price as an argument, and calculate and return the discounted price if campaign's requirement is satisfied.
// The method should return the same price if discount is not given.

using System;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPrice = Convert.ToInt32(Console.ReadLine());
            Console.Write(Discount(totalPrice));
        }
        static int Discount(int price)
        {
            return price >= 10000 ? price -= (int)(0.2 * price) : price;
        }
    }
}