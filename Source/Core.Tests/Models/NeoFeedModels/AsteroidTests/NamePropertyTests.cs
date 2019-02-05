using Core.Models.NeoFeedModels;
using NUnit.Framework;

namespace Core.Tests.Models.NeoFeedModels.AsteroidTests
{
    [TestFixture]
    public class NamePropertyTests
    {
        [Test]
        public void GetAndSetName()
        {
            string expected = "asteroid";

            Asteroid asteroid = new Asteroid();
            asteroid.Name = expected;

            string actual = asteroid.Name;

            Assert.AreEqual(actual, expected);
        }
    }
}