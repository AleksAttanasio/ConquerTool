using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConquerToolMethod;

namespace ConquerMethodTest
{
    [TestClass]
    public class TimeEvaluationTest
    {
        [TestMethod]
        public void Method_TimeCheck()
        {
            int xStart = 0;
            int yStart = 0;
            int xEnd = 5;
            int yEnd = 10;

            TimeSpan check = new TimeSpan(3, 43, 36);

            Assert.AreEqual(check, TimeEvaluation.CourseTimeEvaluation(xStart, yStart, xEnd, yEnd, 0, 3));
        }
    }
}
