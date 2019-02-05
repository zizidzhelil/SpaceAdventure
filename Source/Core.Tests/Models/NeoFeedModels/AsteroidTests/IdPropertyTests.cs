using Core.Models.NeoFeedModels;
using NUnit.Framework;

namespace Core.Tests.Models.NeoFeedModels.AsteroidTests
{
    [TestFixture]
    public class IdPropertyTests
    {
        [Test]
        public void GetAndSetId()
        {
            string expected = "1";

            Asteroid asteroid = new Asteroid();
            asteroid.Id = expected;

            string actual = asteroid.Id;

            Assert.AreEqual(actual, expected);
        }
    }
}