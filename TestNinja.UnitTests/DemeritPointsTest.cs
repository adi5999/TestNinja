
using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    public class DemeritPointsTest
    {
        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void CalcDemPoint_sppedoutofRange_ExceptionThrow(int speed) 
        {
            var calc = new DemeritPointsCalculator();
            Assert.That(()=>calc.CalculateDemeritPoints(speed),
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        
          }
        public void CalcDemPoint_SpeedlimitOrOver_addPoint() { }
        [Test]
        [TestCase(0,0)]
        [TestCase(58,0)]
        [TestCase(65,0)]
        [TestCase(70,1)]
        [TestCase(75,2)]

        public void CalcDemPoint_Called_points (int speed, int point)
        {
            var cal = new DemeritPointsCalculator();
            var result= cal.CalculateDemeritPoints(speed);
            Assert.That(result==point);

        }
    }
}
