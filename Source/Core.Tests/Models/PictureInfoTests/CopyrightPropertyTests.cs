using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.PictureInfoTests
{
    [TestFixture]
    public class CopyrightPropertyTests
    {
        [Test]
        public void GetAndSetCopyright()
        {
            string expected = "2019";

            PictureInfo picture = new PictureInfo();
            picture.Copyright = expected;

            string actual = picture.Copyright;

            Assert.AreEqual(actual, expected);
        }
    }
}
