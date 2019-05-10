using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingProject
{
    class Bowler
    {
        //has this
        public int rollScore;
        

        //constructor
        public Bowler()
        {
        }
        //does this
        public int RollBall(Random r)
        {          
            rollScore = r.Next(0,11);
            return rollScore;
        }
    }
}
