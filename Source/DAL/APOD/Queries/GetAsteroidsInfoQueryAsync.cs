using Common.Constants;
using Core.Models.NeoFeedModels;
using DAL.Factories.ConcreteUrlBuilders;
using Infrastructure.APOD.Queries;
using Infrastructure.Context;
using Infrastructure.UrlFactory;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.APOD.Queries
{
    public class GetAsteroidsInfoQueryAsync : IGetAsteroidsInfoQueryAsync
    {
        private readonly INasaContext _nasaContext;
        private readonly IUrlFactory _urlFactory;

        public GetAsteroidsInfoQueryAsync(INasaContext nasaContext, IUrlFactory urlFactory)
        {
            _nasaContext = nasaContext;
            _urlFactory = urlFactory;
        }

        public async Task<AsteroidsInfo> ExecuteAsync(DateTime startDate, DateTime endDate)
        {
            string result = await _nasaContext.MakeStringRequest(
                _urlFactory.Create(
                    nameof(GetAsteroidsInfoUrlBuilder), 
                    startDate.ToString(CommonConstants.NasaApiDateFormat),
                    endDate.ToString(CommonConstants.NasaApiDateFormat)));

            AsteroidsInfo asteroidsInfo = JsonConvert.DeserializeObject<AsteroidsInfo>(result);

            JObject partialObject = JObject.Parse(result);

            asteroidsInfo.NearEarthObjects.Asteroids = new List<Asteroid>();

            List<Asteroid> asteroids = new List<Asteroid>();
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                 asteroids = partialObject
                    .SelectToken($"near_earth_objects.{date.ToString(CommonConstants.NasaApiDateFormat)}")
                    .ToObject<List<Asteroid>>();

                asteroids.ForEach(f => f.AsteroidSearchDate = date);

                asteroidsInfo.NearEarthObjects.Asteroids.AddRange(asteroids);
            }

            return asteroidsInfo;
        }
    }
}