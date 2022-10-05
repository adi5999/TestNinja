using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using TestNinja.Fundamentals;
using Assert = NUnit.Framework.Assert;

namespace TestNinja.UnitTests
{
    public class FizzBuzztests
    {
        [Test]
        public void GetOp_divby3n5_FizzBzz()
        {
            var res = FizzBuzz.GetOutput(30);
            Assert.That(res, Is.EqualTo ("FizzBuzz"));
        }
        [Test]
        public void GetOp_divby3_Fizz() 
        {
            var res = FizzBuzz.GetOutput(27);
            Assert.That(res, Is.EqualTo("Fizz"));
        }
        public void GetOp_divby5_Bzz()
        {
            var res = FizzBuzz.GetOutput(75);
            Assert.That(res, Is.EqualTo("Buzz"));
        }
        public void GetOP_no_same()
        {
            var res = FizzBuzz.GetOutput(2);
            Assert.That(res == "Not div by both");
        }
    }
}
