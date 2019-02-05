using Core.Models.NeoFeedModels;
using NUnit.Framework;

namespace Core.Tests.Models.NeoFeedModels.AsteroidTests
{
    [TestFixture]
    public class AbsoluteMagnitudePropertyTests
    {
        [Test]
        public void GetAndSetAbsoluteMagnitude()
        {
            double expected = 0.245;

            Asteroid asteroid = new Asteroid();
            asteroid.AbsoluteMagnitude = expected;

            double actual = asteroid.AbsoluteMagnitude;

            Assert.AreEqual(actual, expected);
        }
    }
}