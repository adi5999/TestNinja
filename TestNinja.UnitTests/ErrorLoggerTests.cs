

using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        [Test]
        public void Log_Shows_error ()
        {
            var logger = new ErrorLogger();
             logger.Log("Not Found");
            Assert.That(logger.LastError=="Not Found");
        }
        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidErro_Null(string error)
        {
            var logger= new ErrorLogger();
            Assert.That(() => logger.Log(error), Throws.ArgumentNullException);
        }

        [Test]
        public void Log_Validator_Evet() 
        {
            var logger = new ErrorLogger();
            var id = Guid.Empty;
            logger.ErrorLogged += (sender, args) => { id = args; };
            logger.Log("a");

            Assert.That(id!=Guid.Empty);
        }

       
    }
}
