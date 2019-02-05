using Core.Models.NeoFeedModels;
using NUnit.Framework;

namespace Core.Tests.Models.NeoFeedModels.AsteroidTests
{
    [TestFixture]
    public class NasaPictureUrlPropertyTests
    {
        [Test]
        public void GetAndSetNasaPictureUrl()
        {
            string expected = "http://ssd.jpl.nasa.gov/sbdb.cgi?sstr=3553060";

            Asteroid asteroid = new Asteroid();
            asteroid.NasaPictureUrl = expected;

            string actual = asteroid.NasaPictureUrl;

            Assert.AreEqual(actual, expected);
        }
    }
}