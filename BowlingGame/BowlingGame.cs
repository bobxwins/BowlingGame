using System;


namespace Bowling
{
    public class BowlingGame
    {
        private int[] throws = new int[21];
        private int currentThrow = 0;
     
        static void Main(string[] args)
        {
            
            BowlingGame[] games = new BowlingGame[4];
            games[0] = new BowlingGame();
            games[1] = new BowlingGame();
            games[2] = new BowlingGame();
            games[3] = new BowlingGame();
            games[0].ThrowSpare(games[0]);
            games[1].ThrowStrike(games[1]);
            games[2].ThrowOnes(games[2]);
            games[3].ThrowGutter(games[3]);
             
        }
        public int CalcScore()
        {

            int score = 0;
            int throwIndex = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                 
                
            if (SpareBool(throwIndex))
                {
                    score += 10 + throws[throwIndex + 2];
                    throwIndex += 2;
                    // 1 frame = 2 kast, hvis der spare
                     
                }
               else if (StrikeBool(throwIndex))
                {
                    score += 10 + throws[throwIndex + 1] + throws[throwIndex + 2];
                    throwIndex++;
                    // 1 frame = 1 kast hvis der strike
                    
                }
                else
                {
                    score += throws[throwIndex] + throws[throwIndex + 1];
                    throwIndex += 2;
                    // 1 frame = 2 kast hvis ik der strike
                }
               
            }
          
            return score;
    
        }
        private bool SpareBool(int throwIndex)
        {
            
            return throws[throwIndex] + throws[throwIndex+1]  == 10;
            // hvis 2 kast i 1 frame giver 10 = Spare
        }

        private bool StrikeBool(int throwIndex)
        {
            return throws[throwIndex] == 10;
            // hvis 1 kast  giver 10 = strike
        }

        public int Throw(int pins) {
            return throws[currentThrow++] = pins;
            //Det kast man kaster er ligmed antal pins væltet,
            // currentThrow++ bruges fordi for hver kast skal currentThrow stige med 1, starter med 0

        }

        private void ThrowMultiple(int pinsDown, int throwCount)
        {
            for (int i = 0; i < throwCount; i++)
            {
                Throw(pinsDown);
            }
 
        }
        private void ThrowSpare(BowlingGame game)
        {
            game.Throw(7);
            game. Throw(3);
            game. Throw(1);
            game. ThrowMultiple(0, 17);
            Console.Write("Game 1:       ");
            foreach (var item in throws)
            {
           
                Console.Write(item.ToString() + " ");
            }
            Console.Write("         Game score: "+ game.CalcScore());
            Console.WriteLine();
 
        }
        private void ThrowStrike(BowlingGame game)
        { 
            game.Throw(10);
            game.Throw(1);
            game.Throw(1);
            game.ThrowMultiple(0, 16);
            Console.Write("Game 2:       ");
             foreach (var item in game.throws)
                 {
                 
                Console.Write(item.ToString() + " ");
                 
            }


            Console.Write("        Game score: " + game.CalcScore());
            Console.WriteLine();
        }
        private void ThrowOnes(BowlingGame game)
        {
           
            game.ThrowMultiple(1, 20);
            Console.Write("Game 3:       ");
            foreach (var item in game.throws)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.Write("         Game score: " + game.CalcScore());
            Console.WriteLine();
        }
        private void ThrowGutter(BowlingGame game)
        {
         
            game.ThrowMultiple(0, 20);
            Console.Write("Game 4:       ");
            foreach (var item in game.throws)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.Write("         Game score: " + game.CalcScore());
            Console.WriteLine();
        }
        //private void results()
        //{
        //    int winner = int.MaxValue;
        //    //int loser =
        //}
    }
    }


