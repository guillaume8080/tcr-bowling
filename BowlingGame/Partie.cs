using System;

namespace BowlingGame
{
    public class Partie
    {
        public int score = 0;
        public int frame = 10;
        public int actualFrame = 0;

        public Partie partie()
        {
            while (actualFrame < frame)
            {
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
