using Core.Models.NeoFeedModels;
using System.Collections.Generic;

namespace Infrastructure.Tests.Mocks.MockData
{
    public class AsteroidMock
    {
        public static readonly Asteroid GetAsteroid = new Asteroid()
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
        };
    }
}
