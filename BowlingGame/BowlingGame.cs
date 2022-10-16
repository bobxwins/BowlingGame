using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    public class BowlingGame
    {
        private int[] totalThrows = new int[21];
        private int currentThrow = 0;
         

       
        static void Main(string[] args)
        {
            int gameCount = 0;
            BowlingGame[] games = new BowlingGame[4];
            games[0] = new BowlingGame();
            games[1] = new BowlingGame();
            games[2] = new BowlingGame();
            games[3] = new BowlingGame();
            games[0].ThrowSpare(games[0]);
            games[1].ThrowStrike(games[1]);
            games[2].ThrowOnes(games[2]);
            games[3].ThrowGutter(games[3]);
             
         
            //foreach (var item in games)
            //{
            //    Console.WriteLine(item.CalcScore());
            //    Console.WriteLine("THE INDEX IS" + games.Max().CalcScore());
            //}
        }
        public int CalcScore ()
        {
             
            int score = 0;
            int throwIndex = 0;
            for (int frame = 0; frame < 10; frame++)   
            {
                if (SpareBool(throwIndex))
                {
                    score += SpareScore(throwIndex);
                    throwIndex += 2;
                }
               else if (StrikeBool(throwIndex))
                {
                    score += StrikeScore(throwIndex);
                    throwIndex++;
                }
                else
                {
                    score += NormalThrow(throwIndex);
                    throwIndex += 2;
                }
               
            }

            return score;
    
        }

        private int SpareScore(int throwIndex)
        {
            return totalThrows[throwIndex] + totalThrows[throwIndex + 1] + totalThrows[throwIndex + 2];
        }

        private bool SpareBool(int throwIndex)
        {
            return totalThrows[throwIndex] + totalThrows[throwIndex] + 1 == 10;
        }
        private int StrikeScore(int throwIndex)
        {
            return totalThrows[throwIndex] + totalThrows[throwIndex + 1] + totalThrows[throwIndex + 2];
        }

        private bool StrikeBool(int throwIndex)
        {
            return totalThrows[throwIndex] == 10;
        }

        private int NormalThrow(int throwIndex) // Hverken strike eller spare
        {
            return totalThrows[throwIndex] + totalThrows[throwIndex + 1];
        }

        public int Throws(int pins) {
           return totalThrows[currentThrow++] = pins;        
        }

        private void ThrowMultiple(int pinsDown, int throwCount)
        {
            for (int i = 0; i < throwCount; i++)
            {
                Throws(pinsDown);
            }
 
        }
        private void ThrowSpare(BowlingGame game)
        {
            game.Throws(7);
            game. Throws(3);
            game. Throws(1);
            game. ThrowMultiple(0, 17);
            Console.Write("Game 1:       ");
            foreach (var item in totalThrows)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.Write("         Game score: "+ game.CalcScore());
            Console.WriteLine();
        }
        private void ThrowStrike(BowlingGame game)
        { 
            game.Throws(10);
            game.Throws(1);
            game.Throws(1);
            game.ThrowMultiple(0, 16);
            Console.Write("Game 2:       ");
            foreach (var item in game.totalThrows)
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
            foreach (var item in game.totalThrows)
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
            foreach (var item in game.totalThrows)
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


