//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using TestNinja.Fundamentals;
using TestNinja.UnitTests;

namespace TestNinja.UnitTests
{
    //[TestClass]
    [TestFixture]
    public class ReservationTests
    {
        //[TestMethod]
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            var reservation=new Reservation();
            //act
            var result=reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //assert
            Assert.IsTrue(result);
        }
        [Test]
        public void CanBeCancelledBy_SameUserCancellingTheReservation_ReturnTrue()
        {
            var user = new User();
            var reservation = new Reservation { MadeBy = user };
            //aarrange
            var result= reservation.CanBeCancelledBy(user);   
            //act

            Assert.IsTrue(result);
            //assert
        }
        [Test]
        public void CanBeCancelledBy_AnotherUsercancellingReservation_RetutnsFalse()
        {
            var reservation = new Reservation { MadeBy = new User() };

            var result = reservation.CanBeCancelledBy(new User());
            Assert.IsFalse(result);
        }
    }
}
