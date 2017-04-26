using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class HumanPlayer : IPlayer
    {
        int getNextMove()
        {
            while (true)
            {
                Console.Write("Enter r for rock, p for paper, or s for scissors (q to quit): ");
                string choice = Console.ReadLine().ToLower();
                if (choice == "r")
                {
                    return 0;
                }
                if (choice == "p")
                {
                    return 1;
                }
                if (choice == "s")
                {
                    return 2;
                }
                if (choice == "q")
                {
                    return -1;
                }
                Console.WriteLine("I didn't understand that.");
            }
        }


        public int NextMove()
        {
            return getNextMove();
        }

        public void SaveResult(int myMove, int otherMove)
        {
            // do nothing
        }
    }
}
