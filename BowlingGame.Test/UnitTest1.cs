using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGame.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void getLeScoreMax()
        {
            // calculer scoremax avec extraball
            int scoreMaxPossible = 300;
            int score = 0;
            
            int nombreOfFramePasse = 10;
            nombreOfFramePasse = nombreOfFramePasse;
            
            for (int i = 0; i < nombreOfFramePasse; i++)
            {
                score = score + 10;
                score = score + 20;
            }

            if (score > scoreMaxPossible)
            {
                Assert.Fail();
            }
            


        }
    }
}