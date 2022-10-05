using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test] 
        //[Ignore("just tedsting")]
        public void Add_WhenCalled_ReturnSum()
        {
         //   var math = new Math() ;
            var result= _math.Add(1, 499);
           Assert.That(result , Is.EqualTo(500));
            //Assert.That(_math,Is.Not.Null);
        }

        //[Test]
        //public void Max_FirstGreaterThan_returnsFirst()
        //{
        //   // var math = new Math();
        //    var result= _math.Max(20, 10);
        //    Assert.That(result,Is.EqualTo(20));
        //}
        //[Test]
        //public void Max_SecondGreaterThan_returnsSecond()
        //{
        //   // var math = new Math();
        //    var result = _math.Max(10, 20);
        //    Assert.That(result, Is.EqualTo(20));
        //}
        //[Test]
        //public void Max_Equals_returnsSsame()
        //{
        //    //var math = new Math();
        //    var result = _math.Max(1,1);
        //    Assert.That(result, Is.EqualTo(1));
        //}

        [Test]
        [TestCase(20,10,20)]
        [TestCase(10,20,20)]
        [TestCase(10,10,10)]

        public void Max_Number_greater(int a, int b , int expRes) 
        {
            var reault = _math.Max(a, b);
            Assert.That(reault , Is.EqualTo(expRes));
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNO()
        {
           var result= _math.GetOddNumbers(5);
            // Assert.That(result !=null);
            // Assert.That(result.Count() == 3);
            //Assert.That(result.Contains(1));
            //Assert.That(result.Contains(3));
            //Assert.That(result.Contains(5));
            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));
        }
    }
}
