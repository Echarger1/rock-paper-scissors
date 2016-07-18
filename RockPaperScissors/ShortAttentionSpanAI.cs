using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class ShortAttentionSpanAI : IPlayer
    {
        int lastMove;
        Random Random = new Random();
        int randommove;
        public int NextMove()
        {
            
            if (lastMove == 0)
            {
                return 1;
            }
            if (lastMove == 1)
            {
                return 2;
            }
            else
            {
                randommove = Random.Next(0, 3); ;
            }
            return randommove;
        }

        public void SaveResult(int myMove, int otherMove)
        {
            lastMove = otherMove;

        }
    }
}
