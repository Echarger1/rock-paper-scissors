using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class StubbornAI : IPlayer
    {
        public StubbornAI(int Favoritemove)
        {
            favoritemove = Favoritemove;
        }
        int favoritemove = 0;
        public int NextMove()
        {
            return favoritemove;
        }

        public void SaveResult(int myMove, int otherMove)
        {
        }
    }
}
