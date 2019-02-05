using Core.Models.NeoFeedModels;
using NUnit.Framework;

namespace Core.Tests.Models.NeoFeedModels.AsteroidTests
{
    [TestFixture]
    public class EstimatedDiameterPropertyTests
    {
        [Test]
        public void GetAndSetEstimatedDiameter()
        {
            var expected = new Diameter
            {
                Kilometers = new Kilometers
                {
                    Min = 0.1,
                    Max = 6.3
                }
            };

            Asteroid asteroid = new Asteroid();
            asteroid.EstimatedDiameter = expected;

            var actual = asteroid.EstimatedDiameter;

            Assert.AreEqual(actual, expected);
        }
    }
}