using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.PictureInfoTests
{
    [TestFixture]
    public class UrlPropertyTests
    {
        [Test]
        public void GetAndSetUrl()
        {
            string expected = "https://apod.nasa.gov/apod/image/1901/UT-blink_3d_a.gif";

            PictureInfo picture = new PictureInfo();
            picture.Url = expected;

            string actual = picture.Url;

            Assert.AreEqual(actual, expected);
        }
    }
}
