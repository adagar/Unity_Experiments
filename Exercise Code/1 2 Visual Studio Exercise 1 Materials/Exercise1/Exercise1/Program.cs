using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCards;

namespace Exercise1
{
    /// <summary>
    /// Exercise 1 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Practices using arrays
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            //Exercise 1
            Deck deck = new Deck();
            Card[] hand = new Card[5];
            deck.Shuffle();
            Console.WriteLine("deck shuffled");
            Console.WriteLine();

            //Problem 2
            hand[0] = deck.TakeTopCard();
            hand[0].FlipOver();
            hand[0].Print();

            //Problem 3
            hand[1] = deck.TakeTopCard();
            hand[1].FlipOver();
            hand[0].Print();
            hand[1].Print();
        }
    }
}
