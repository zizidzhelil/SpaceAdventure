using Core.Models.NeoFeedModels;
using NUnit.Framework;

namespace Core.Tests.Models.NeoFeedModels.AsteroidTests
{
    [TestFixture]
    public class IsPotentiallyHazardousAsteroidPropertyTests
    {
        [Test]
        public void GetAndSetIsPotentiallyHazardousAsteroid()
        {
            bool expected = true;

            Asteroid asteroid = new Asteroid();
            asteroid.IsPotentiallyHazardousAsteroid = expected;

            bool actual = asteroid.IsPotentiallyHazardousAsteroid;

            Assert.AreEqual(actual, expected);
        }
    }
}