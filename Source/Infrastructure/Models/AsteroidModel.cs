using Core.Models.NeoFeedModels;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Models
{
    public class AsteroidModel
    {
        public AsteroidModel(Asteroid asteroid)
        {
            Name = asteroid.Name;
            NasaPictureUrl = asteroid.NasaPictureUrl;
            AbsoluteMagnitude = asteroid.AbsoluteMagnitude;
            EstimatedDiameter = asteroid.EstimatedDiameter = new Diameter
            {
                Kilometers = new Kilometers
                {
                    Min = asteroid.EstimatedDiameter.Kilometers.Min,
                    Max = asteroid.EstimatedDiameter.Kilometers.Max
                }
            };
            CloseApproachData = asteroid.CloseApproachData = new List<CloseApproachData>
            {
                new CloseApproachData
                {
                    CloseApproachDate = asteroid.CloseApproachData.Last().CloseApproachDate,
                    RelativeVelocity = new RelativeVelocity
                    {
                        KilometersPerSecond = asteroid.CloseApproachData.Last().RelativeVelocity.KilometersPerHour,
                        KilometersPerHour = asteroid.CloseApproachData.Last().RelativeVelocity.KilometersPerSecond
                    },
                    MissDistance = new Distance
                    {
                        Kilometers = asteroid.CloseApproachData.Last().MissDistance?.Kilometers,
                        Astronomical = asteroid.CloseApproachData.Last().MissDistance?.Astronomical,
                        Lunar = asteroid.CloseApproachData.Last().MissDistance?.Lunar
                    },
                    OrbitingBody = asteroid.CloseApproachData.Last().OrbitingBody
                }
            };
        }

        public string Name { get; set; }

        public string NasaPictureUrl { get; set; }

        public double AbsoluteMagnitude { get; set; }

        public Diameter EstimatedDiameter { get; set; }

        public List<CloseApproachData> CloseApproachData { get; set; }
    }
}