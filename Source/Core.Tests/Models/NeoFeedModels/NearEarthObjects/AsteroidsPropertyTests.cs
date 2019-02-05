using Core.Models.NeoFeedModels;
using NUnit.Framework;
using System.Collections.Generic;

namespace Core.Tests.Models.NeoFeedModels
{
    [TestFixture]
    public class AsteroidsPropertyTests
    {
        [Test]
        public void GetAndSetAsteroids()
        {
            var expected = new List<Asteroid>
            {
                new Asteroid
                {
                        Id = "1",
                        Name = "astro",
                        NasaPictureUrl = "http://ssd.jpl.nasa.gov/sbdb.cgi?sstr=3553060",
                        AbsoluteMagnitude = 0.3,
                        EstimatedDiameter = new Diameter
                        {
                            Kilometers = new Kilometers
                            {
                                Min = 0.2,
                                Max = 6.8
                            }
                        },
                        IsPotentiallyHazardousAsteroid = false,
                        CloseApproachData = new List<CloseApproachData>
                        {
                            new CloseApproachData
                            {
                                CloseApproachDate = "some",
                                EpochDateCloseApproach = new object(),
                                RelativeVelocity = new RelativeVelocity
                                {
                                    KilometersPerHour = "12",
                                    KilometersPerSecond = "12000"
                                },
                                MissDistance = new Distance
                                {
                                    Astronomical = "12",
                                    Lunar = "65",
                                    Kilometers = "9"
                                },
                                OrbitingBody = "ab"
                            }
                        },
                        IsSentryObject = false
                }
            };

            NearEarthObjects nearEarthObjects = new NearEarthObjects();
            nearEarthObjects.Asteroids = expected;

            var actual = nearEarthObjects.Asteroids;

            Assert.AreEqual(actual, expected);
        }
    }
}
