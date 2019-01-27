using Core.Models.NeoFeedModels;
using Infrastructure.APOD.Queries;
using Infrastructure.Grouper;
using Infrastructure.Models;
using Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BL.Services
{
    public class AsteroidsInfoService : IAsteroidsInfoService
    {
        private readonly IGetAsteroidsInfoQueryAsync _getAsteroidsInfoQueryAsync;
        private readonly IGroupAsteroidsByDay _groupAsteroidsByDay;

        public AsteroidsInfoService(
            IGetAsteroidsInfoQueryAsync getAsteroidsInfoQueryAsync,
            IGroupAsteroidsByDay groupAsteroidsByDay)
        {
            _getAsteroidsInfoQueryAsync = getAsteroidsInfoQueryAsync;
            _groupAsteroidsByDay = groupAsteroidsByDay;
        }

        public async Task<List<AsteroidsByDaysModel>> GetAsteroidsInfoAsync(DateTime startDate, DateTime endDate)
        {
            AsteroidsInfo asteroidsInfo = await _getAsteroidsInfoQueryAsync.ExecuteAsync(startDate, endDate);
            List<AsteroidsByDaysModel> groupedAsteroids = _groupAsteroidsByDay.Group(asteroidsInfo).ToList();

            return groupedAsteroids;
        }
    }
}