using Core.Models.NeoFeedModels;
using Infrastructure.Models;
using System.Collections.Generic;

namespace SpaceAdventure.Tests.Mocks.MockData
{
    public static class AsteroidsByDaysModelMock
    {
        public static readonly Asteroid AsteroidMock = new Asteroid
        {
            Name = "(2015 RC)",
            NasaPictureUrl = "http://ssd.jpl.nasa.gov/sbdb.cgi?sstr=3726710",
            AbsoluteMagnitude = 1.3,
            EstimatedDiameter = new Diameter
            {
                Kilometers = new Kilometers
                {
                    Min = 0.1,
                    Max = 9.9
                }
            },
            CloseApproachData = new List<CloseApproachData>
            {
                new CloseApproachData
                {
                    CloseApproachDate = "2015-09-08",
                    RelativeVelocity = new RelativeVelocity
                    {
                        KilometersPerSecond = "19.48",
                        KilometersPerHour = "70146.10"
                    },
                    MissDistance = new Distance
                    {
                        Kilometers = "4027630.25",
                        Astronomical = "0.0269",
                        Lunar = "10.47"
                    },
                    OrbitingBody = "Earth"
                }
            }
        };

        public static readonly List<AsteroidsByDaysModel> AsteroidsByDaysModelMocks = new List<AsteroidsByDaysModel>
        {
            new AsteroidsByDaysModel
            {
                Date = "2019-01-30",
                Asteroids = new List<AsteroidModel>
                {
                    new AsteroidModel(AsteroidMock)        
                }
            }
        };
    }
}
