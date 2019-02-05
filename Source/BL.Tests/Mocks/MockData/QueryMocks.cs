using Core.Models;
using Core.Models.NeoFeedModels;
using Infrastructure.Models;
using System.Collections.Generic;

namespace BL.Tests.Mocks.MockData
{
    public class QueryMocks
    {
        public static readonly PictureInfo GetPictureInfoQueryResult = new PictureInfo()
        {
            Copyright = "2019",
            Date = "2019-01-06",
            Explanation = "Ultima Thule is the most distant world explored by a spacecraft from Earth.",
            HDUrl = "https://apod.nasa.gov/apod/image/1901/UT-blink_3d_a.gif",
            MediaType = "image",
            ServiceVersion = "v1",
            Title = "Ultima Thule Rotation Gif",
            Url = "https://apod.nasa.gov/apod/image/1901/UT-blink_3d_a.gif"
        };
        public static readonly AsteroidsInfo GetAsteroidsInfoQueryResult = new AsteroidsInfo()
        {
            ElementCount = 4,
            NearEarthObjects = new NearEarthObjects
            {
                Asteroids = new List<Asteroid>
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
                }
            }
        };
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

        public static readonly PictureForDayModel PictureForDay = new PictureForDayModel(GetPictureInfoQueryResult, new byte[] { 123 });
        public static readonly List<AsteroidsByDaysModel> AsteroidsByDays = new List<AsteroidsByDaysModel>();
    }
}