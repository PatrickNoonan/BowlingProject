using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingProject
{
    class ScoreBoard
    {
        //has this
        public Frame ScoreFrame0;
        public Frame ScoreFrame1;
        public Frame ScoreFrame2;
        public Frame ScoreFrame3;
        public Frame ScoreFrame4;
        public Frame ScoreFrame5;
        public Frame ScoreFrame6;
        public Frame ScoreFrame7;
        public Frame ScoreFrame8;
        public Frame ScoreFrame9;
        public List<Frame> FramesList;
        public int runningTotal;
        public int currentFrame = 0;
        public Random rng;
        public string stringOfScores;
        

        //constructor
        public ScoreBoard()
        {
            ScoreFrame0 = new Frame();
            ScoreFrame1 = new Frame();
            ScoreFrame2 = new Frame();
            ScoreFrame3 = new Frame();
            ScoreFrame4 = new Frame();
            ScoreFrame5 = new Frame();
            ScoreFrame6 = new Frame();
            ScoreFrame7 = new Frame();
            ScoreFrame8 = new Frame();
            ScoreFrame9 = new Frame();
            FramesList = new List<Frame> { ScoreFrame0, ScoreFrame1, ScoreFrame2, ScoreFrame3, ScoreFrame4, ScoreFrame5, ScoreFrame6, ScoreFrame7, ScoreFrame8, ScoreFrame9 };            
            runningTotal = 0;
            rng = new Random();
        }

        //does this
        public void AddScore(int roll, string firstOrSecond)
        {
            if (firstOrSecond == "first")
            {
                FramesList[currentFrame].rollOne = roll;
            }
            else if (firstOrSecond == "second")
            {
                FramesList[currentFrame].rollTwo = roll;
            }
        }
        public void GetBasicTotal()
        {
            for (int i = 0; i < 10; i++)
            {
                runningTotal += (FramesList[i].rollOne + FramesList[i].rollTwo);
            }
            Console.WriteLine(runningTotal);
            Console.ReadLine();
        }        
        public void GetTotalWStrikes()
        {
            for (int i = 0; i < 10; i++)
            {
                if (FramesList[i].rollOne == 10)
                {
                    FramesList[i].wasStrike = true;
                    try
                    {
                        if (FramesList[i + 1].rollOne == 10)
                        {
                            runningTotal += (20 + FramesList[i + 2].rollOne);
                        }
                        else
                        {
                            runningTotal += (10 + FramesList[i + 1].rollOne + FramesList[i + 1].rollTwo);
                        }
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        if (rng.Next(0, 11) == 10)
                        {
                            runningTotal += (20 + rng.Next(0, 11));
                        }
                        else
                        {
                            runningTotal += (10 + rng.Next(0, 11) + rng.Next(0, 11));
                        }
                    }
                }
                else if ((FramesList[i].rollOne + FramesList[i].rollTwo) >= 10)
                {
                    FramesList[i].wasSpare = true;
                    try
                    {
                        runningTotal += (10 + FramesList[i + 1].rollOne);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        runningTotal += (10 + rng.Next(0, 11));
                    }
                    
                }
                else if ((FramesList[i].rollOne + FramesList[i].rollTwo) < 10)
                {
                    runningTotal += (FramesList[i].rollOne + FramesList[i].rollTwo);
                }
            }
        }

        public string OutPutScoreBoard()
        {            
            for (int i = 0; i < FramesList.Count; i++)
            {
                if (FramesList[i].wasStrike == true)
                {
                    stringOfScores += "X ";
                }
                else if (FramesList[i].wasSpare == true)
                {
                    stringOfScores += FramesList[i].rollOne + " / ";
                }
                else
                {
                    stringOfScores += FramesList[i].rollOne + " " + FramesList[i].rollTwo + " ";
                }
            }
            return stringOfScores;
        }
    }
}
