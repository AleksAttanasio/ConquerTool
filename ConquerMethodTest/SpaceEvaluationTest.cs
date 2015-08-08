using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConquerToolMethod;

namespace ConquerMethodTest
{
    [TestClass]
    public class SpaceEvaluationTest
    {
        [TestMethod]
        public void Method_DistanceCheck()
        {
            int xStart = 0;
            int yStart = 0;
            int xEnd = 3;
            int yEnd= 4;

            float distance = SpaceEvaluation.EvaluateDistance(xStart, yStart, xEnd, yEnd);
            Assert.AreEqual(distance, 5);
        }
    }
}
