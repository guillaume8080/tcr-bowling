using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGame;

namespace BowlingGame.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void getStrike()
        {
            Partie partie = new Partie();
            int score = partie.score;


            if (partie.isStrike())
            {
                if (score != 10)
                {
                    Assert.Fail();
                }
            }

        }

        [TestMethod]
        public void checkNombreDeLancer()
        {
            Partie partie = new Partie();
            
            if (partie.nbDeLance > 2 )
            {
                Assert.Fail();
            }

            
            

        }
    }
}
    

