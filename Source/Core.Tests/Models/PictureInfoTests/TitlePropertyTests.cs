using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.PictureInfoTests
{
    [TestFixture]
    public class TitlePropertyTests
    {
        [Test]
        public void GetAndSetTitle()
        {
            string expected = "Ultima Thule Rotation Gif";

            PictureInfo picture = new PictureInfo();
            picture.Title = expected;

            string actual = picture.Title;

            Assert.AreEqual(actual, expected);
        }
    }
}
