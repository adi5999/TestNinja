using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mockingtests
{
    [TestFixture]
    public class InstallerHelperTests
    {
        private Mock<IFileDownloader> _fileDownloader;
        private InstallerHelper _installerHelper;

        [SetUp]
        public void Setup() 
        {
            _fileDownloader = new Mock<IFileDownloader>();
                 _installerHelper = new InstallerHelper(_fileDownloader.Object);
        }

        
    }
}
