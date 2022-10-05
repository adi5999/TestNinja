using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]  
        public void GetCustomer_ID_returnsNotExits()     
        {
            var customer = new CustomerController();
            var resuly = customer.GetCustomer(0);
            Assert.That(resuly, Is.TypeOf<NotFound>());
        }
    }
}
