using Core.Models.NeoFeedModels;
using Infrastructure.Models;
using Infrastructure.Tests.Mocks.MockData;
using NUnit.Framework;
using System.Collections.Generic;

namespace Infrastructure.Tests.ModelsTests.AsteroidModelTests
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

            AsteroidModel model = new AsteroidModel(AsteroidMock.GetAsteroid);
            model.CloseApproachData = expected;

            var actual = model.CloseApproachData;

            Assert.AreEqual(actual, expected);
        }
    }
}