using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    public class BowlingGame
    {
        private int[] totalThrows = new int[21];
        private int currentThrow = 0;
        BowlingGame game;
        static void Main(string[] args)
        {
            Console.WriteLine("Der bowles!");
           
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
            Console.WriteLine(totalThrows[currentThrow++] = pins);
           return totalThrows[currentThrow++] = pins;        
        }

        private void ThrowMultiple(int pinsDown, int throwCount)
        {
            for (int i = 0; i < throwCount; i++)
            {
                game.Throws(pinsDown);

            }

        }
        private void ThrowSpare()
        {
            game.Throws(7);
            game.Throws(3);
            game.Throws(1);
            ThrowMultiple(0, 17);
        }
        private void PrintGame()
        {
            for (int i = 0; i < currentThrow; i++)
            {
          //      game.Throws(pinsDown);

            }
        }
    }

}
