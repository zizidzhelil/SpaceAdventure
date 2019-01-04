using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.PictureInfoTests
{
    [TestFixture]
    public class HDUrlPropertyTests
    {
        [Test]
        public void GetAndSetHDUrl()
        {
            string expected = "https://apod.nasa.gov/apod/image/1901/UT-blink_3d_a.gif";

            PictureInfo picture = new PictureInfo();
            picture.HDUrl = expected;

            string actual = picture.HDUrl;

            Assert.AreEqual(actual, expected);
        }
    }
}
