using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.PictureInfoTests
{
    [TestFixture]
    public class MediaTypePropertyTests
    {
        [Test]
        public void GetAndSetMediaType()
        {
            string expected = "image";

            PictureInfo picture = new PictureInfo();
            picture.MediaType = expected;

            string actual = picture.MediaType;

            Assert.AreEqual(actual, expected);
        }
    }
}
