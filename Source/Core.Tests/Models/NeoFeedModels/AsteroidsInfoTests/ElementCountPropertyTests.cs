using Core.Models.NeoFeedModels;
using NUnit.Framework;

namespace Core.Tests.Models.NeoFeedModels.AsteroidsInfoTests
{
    [TestFixture]
    public class ElementCountPropertyTests
    {
        [Test]
        public void GetAndSetElementCount()
        {
            int expected = 4;

            AsteroidsInfo asteroidsInfo = new AsteroidsInfo();
            asteroidsInfo.ElementCount = expected;

            int actual = asteroidsInfo.ElementCount;

            Assert.AreEqual(actual, expected);
        }
    }
}