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
            else return 0;
        }

        public void SaveResult(int myMove, int otherMove)
        {
            lastMove = otherMove;

        }
    }
}
