using NUnit.Framework;
using TestNinja.Fundamentals;
namespace TestNinja.UnitTests
{
    [TestFixture]
    internal class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_Called_MakeItBold()
        {
            var formatter = new HtmlFormatter();
            var result=formatter.FormatAsBold("abc");
            Assert.That(result,Is.EqualTo( "<strong>abc</strong>"));
        }
    }
}
