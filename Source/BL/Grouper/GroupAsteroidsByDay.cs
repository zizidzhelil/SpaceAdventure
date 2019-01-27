using Common.Constants;
using Core.Models.NeoFeedModels;
using Infrastructure.Grouper;
using Infrastructure.Models;
using System.Collections.Generic;
using System.Linq;

namespace BL.Grouper
{
    public class GroupAsteroidsByDay : IGroupAsteroidsByDay
    {
        public List<AsteroidsByDaysModel> Group(AsteroidsInfo asteroidsInfo)
        {
            List<AsteroidsByDaysModel> asteroidsForDays = asteroidsInfo.NearEarthObjects.Asteroids
                .GroupBy(
                    d => d.AsteroidSearchDate.ToString(CommonConstants.NasaApiDateFormat),
                    a => a)
                .Select(asteroidInfo => new AsteroidsByDaysModel()
                {
                    Date = asteroidInfo.Key,
                    Asteroids = asteroidInfo.Select(a => new AsteroidModel(a)).ToList()
                })
                .ToList();

            return asteroidsForDays;
        }
    }
}