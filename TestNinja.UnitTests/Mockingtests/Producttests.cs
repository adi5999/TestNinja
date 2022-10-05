
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mockingtests
{
    [TestFixture]
    public class Producttests
    {
        [Test]
        public void GetPrice_Gold_per30off()
        {
            var product = new Product { ListPrice = 100 };
           var result= product.GetPrice(new Customer { IsGold=true});
            Assert.That(result == 70);
        }
    }
}
