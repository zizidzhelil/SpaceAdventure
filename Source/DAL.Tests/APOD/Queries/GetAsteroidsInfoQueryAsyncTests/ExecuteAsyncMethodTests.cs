using Common.Constants;
using Core.Models.NeoFeedModels;
using DAL.APOD.Queries;
using DAL.Factories.ConcreteUrlBuilders;
using DAL.Tests.Mocks.MockData;
using Infrastructure.APOD.Queries;
using Infrastructure.Context;
using Infrastructure.UrlFactory;
using Moq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Tests.APOD.Queries.GetAsteroidsInfoQueryAsyncTests
{
    [TestFixture]
    public class ExecuteAsyncMethodTests
    {
        private readonly INasaContext _contextMock;
        private readonly IUrlFactory _urlFactoryMock;

        public ExecuteAsyncMethodTests()
        {
            Mock<INasaContext> contextMock = new Mock<INasaContext>();
            Mock<IUrlFactory> urlFactoryMock = new Mock<IUrlFactory>();

            contextMock.Setup(c => c.MakeStringRequest(It.IsAny<string>())).ReturnsAsync(ResponseMocks.GetAsteroidsInfoMock);
            urlFactoryMock
               .Setup(u => u.Create(nameof(GetAsteroidsInfoUrlBuilder), DateTime.Today.ToString(), DateTime.Today.AddDays(2).ToString()))
               .Returns($"https://api.nasa.gov/neo/rest/v1/feed?start_date=2015-09-07&end_date=2015-09-09&api_key=DEMO_KEY");

            _contextMock = contextMock.Object;
            _urlFactoryMock = urlFactoryMock.Object;
        }

        [Test]
        public async Task ShouldReturnDeserializedObject()
        {
            IGetAsteroidsInfoQueryAsync getAsteroidsInfoQueryAsync = new GetAsteroidsInfoQueryAsync(_contextMock, _urlFactoryMock);

            AsteroidsInfo actualObject = await getAsteroidsInfoQueryAsync.ExecuteAsync(new DateTime(2015, 09, 08), new DateTime(2015, 09, 09));
            AsteroidsInfo expectedObject = JsonConvert.DeserializeObject<AsteroidsInfo>(ResponseMocks.GetAsteroidsInfoMock);

            JObject partialObject = JObject.Parse(ResponseMocks.GetAsteroidsInfoMock);

            expectedObject.NearEarthObjects.Asteroids = new List<Asteroid>();

            List<Asteroid> asteroids = new List<Asteroid>();
            for (DateTime date = new DateTime(2015, 09, 08); date <= new DateTime(2015, 09, 09); date = date.AddDays(1))
            {
                asteroids = partialObject
                   .SelectToken($"near_earth_objects.{date.ToString(CommonConstants.NasaApiDateFormat)}")
                   .ToObject<List<Asteroid>>();

                asteroids.ForEach(f => f.AsteroidSearchDate = date);

                expectedObject.NearEarthObjects.Asteroids.AddRange(asteroids);
            }

            var actual = JsonConvert.SerializeObject(actualObject);
            var expected = JsonConvert.SerializeObject(expectedObject);

            Assert.AreEqual(actual, expected);
        }
    }
}