using Core.Models.NeoFeedModels;
using NUnit.Framework;

namespace Core.Tests.Models.NeoFeedModels.AsteroidTests
{
    [TestFixture]
    public class IsSentryObjectPropertyTests
    {
        [Test]
        public void GetAndSetIsIsSentryObject()
        {
            bool expected = true;

            Asteroid asteroid = new Asteroid();
            asteroid.IsSentryObject = expected;

            bool actual = asteroid.IsSentryObject;

            Assert.AreEqual(actual, expected);
        }
    }
}