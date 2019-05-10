using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingProject
{
    class Game
    {
        //has this
        public Bowler NachoLover420;
        public ScoreBoard TheScoreBoard;
        public int firstRoll;
        public int secondRoll;
        public Random rng;
        public string text;

        //constructor
        public Game()
        {
            NachoLover420 = new Bowler();            
            TheScoreBoard = new ScoreBoard();
            rng = new Random();
        }
        //does this
        public void ChooseGame()
        {
            RunGame();            
        }
        public void RunGame()
        {
            for (int i = 0; i < 10; i++)
            {
                firstRoll = NachoLover420.RollBall(rng);
                secondRoll = NachoLover420.RollBall(rng);
                TheScoreBoard.AddScore(firstRoll, "first");
                TheScoreBoard.AddScore(secondRoll, "second");
                TheScoreBoard.currentFrame ++;
            }
            TheScoreBoard.GetTotalWStrikes();
            text = TheScoreBoard.OutPutScoreBoard() + " The total score is: " + TheScoreBoard.runningTotal;
            System.IO.File.WriteAllText(@"C:\Users\PatrickNNoonan\Documents\Development\DevCodeCamp\Week_04\Bowling-Project\BowlingProject\TestFolder\WriteLines.txt", text);
        }
    }
}
