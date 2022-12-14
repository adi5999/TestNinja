using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class VideoServiceTests
    {
        private Mock<IFileReader> _fileReader;
        private VideoService _videoService;
        private Mock<IVideoRepository> _repository;

        [SetUp]
        public void SetUp()
        {
            _fileReader = new Mock<IFileReader>();
            
            _repository = new Mock<IVideoRepository>();

            _videoService = new VideoService(_fileReader.Object, _repository.Object);
        }

        [Test]
        public void ReadVideoTitle_NoFile_Error()
        {
            
            _fileReader.Setup(fr=>fr.Read("video.txt")).Returns("");
                 var result = _videoService.ReadVideoTitle();


            Assert.That(result, Does.Contain("error").IgnoreCase);
        }

        [Test]
        public void UnprocessedVideo_called_null()
        {
            _repository.Setup(r => r.GetUnprocessedVideos()).Returns(new List<Video>());

          var  resukt=  _videoService.GetUnprocessedVideosAsCsv();
            Assert.That(resukt, Is.EqualTo(""));
        }

        [Test]
        public void UnprocessedVideo_called_ReturnID()
        {
            _repository.Setup(r => r.GetUnprocessedVideos()).Returns(new List<Video>
               { new Video { Id = 1 },
                new Video { Id = 2 },
                new Video { Id = 3 }
                });

          var  resukt=  _videoService.GetUnprocessedVideosAsCsv();
            Assert.That(resukt, Is.EqualTo("1,2,3"));
        }
     

    }
        
}
