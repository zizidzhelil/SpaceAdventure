using Core.Models.NeoFeedModels;
using NUnit.Framework;
using System.Collections.Generic;

namespace Core.Tests.Models.NeoFeedModels.AsteroidTests
{
    [TestFixture]
    public class CloseApproachDataPropertyTests
    {
        [Test]
        public void GetAndSetCloseApproachData()
        {
            var expected = new List<CloseApproachData>
            {
                new CloseApproachData
                {
                    CloseApproachDate = "2019-19-01",
                    EpochDateCloseApproach = new object(),
                    RelativeVelocity = new RelativeVelocity
                    {
                        KilometersPerSecond = "12",
                        KilometersPerHour = "125468741"
                    },
                    MissDistance = new Distance
                    {
                        Astronomical = "12",
                        Lunar = "2",
                        Kilometers = "68"
                    },
                    OrbitingBody = "ab"
                }
            };

            Asteroid asteroid = new Asteroid();
            asteroid.CloseApproachData = expected;

            var actual = asteroid.CloseApproachData;

            Assert.AreEqual(actual, expected);
        }
    }
}