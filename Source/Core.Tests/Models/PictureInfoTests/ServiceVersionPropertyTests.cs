using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.PictureInfoTests
{
    [TestFixture]
    public class ServiceVersionPropertyTests
    {
        [Test]
        public void GetAndSetServiceVersion()
        {
            string expected = "v1";

            PictureInfo picture = new PictureInfo();
            picture.ServiceVersion = expected;

            string actual = picture.ServiceVersion;

            Assert.AreEqual(actual, expected);
        }
    }
}
