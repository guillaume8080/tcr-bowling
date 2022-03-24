using System;
using System.Security.Cryptography;

namespace BowlingGame
{
    public class Partie
    {
        public int score = 0;
        public int frame = 10;
        public int actualFrame = 0;
        public int nbDeLance = 0;
        public int quille = 10;

        public Partie partie()
        {
            while (actualFrame < frame)
            {
                //int fallenQuille = RandomNumberGenerator(0, 10);
                actualFrame++;
            }
            return new Partie();
        }

        public bool isStrike()
        {
            bool strike = false;
            if (score == 10)
            {
                strike = true;
            }
            return strike;
        }
    }
}
