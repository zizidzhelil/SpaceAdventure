using Core.Models;
using NUnit.Framework;

namespace Core.Tests.Models.PictureInfoTests
{
    [TestFixture]
    public class ExplanationPropertyTests
    {
        [Test]
        public void GetAndSetExplanation()
        {
            string expected = "Ultima Thule is the most distant world explored by a spacecraft from Earth.";

            PictureInfo picture = new PictureInfo();
            picture.Explanation = expected;

            string actual = picture.Explanation;

            Assert.AreEqual(actual, expected);
        }
    }
}
