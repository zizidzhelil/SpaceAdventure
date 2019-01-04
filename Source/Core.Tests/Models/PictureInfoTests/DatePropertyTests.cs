using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.PictureInfoTests
{
    [TestFixture]
    public class DatePropertyTests
    {
        [Test]
        public void GetAndSetDate()
        {
            string expected = "2019-01-04";

            PictureInfo picture = new PictureInfo();
            picture.Date = expected;

            string actual = picture.Date;

            Assert.AreEqual(actual, expected);
        }
    }
}
