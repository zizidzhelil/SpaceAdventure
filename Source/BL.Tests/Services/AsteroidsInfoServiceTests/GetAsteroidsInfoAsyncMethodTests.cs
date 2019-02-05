using BL.Services;
using BL.Tests.Mocks.MockData;
using Infrastructure.APOD.Queries;
using Infrastructure.Grouper;
using Infrastructure.Models;
using Moq;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BL.Tests.Services.AsteroidsInfoServiceTests
{
    [TestFixture]
    public class GetAsteroidsInfoAsyncMethodTests
    {
        private readonly DateTime startDate = DateTime.Today;
        private readonly DateTime endDate = DateTime.Today.AddDays(2);

        private readonly IGetAsteroidsInfoQueryAsync _getAsteroidsInfoQueryAsyncMock;
        private readonly IGroupAsteroidsByDay _groupAsteroidsByDay;

        public GetAsteroidsInfoAsyncMethodTests()
        {
            Mock<IGetAsteroidsInfoQueryAsync> getAsteroidsInfoQueryAsyncMock = new Mock<IGetAsteroidsInfoQueryAsync>();
            Mock<IGroupAsteroidsByDay> groupAsteroidsByDayMock = new Mock<IGroupAsteroidsByDay>();

            getAsteroidsInfoQueryAsyncMock
                .Setup(c => c.ExecuteAsync(It.IsAny<DateTime>(), It.IsAny<DateTime>()))
                .ReturnsAsync(QueryMocks.GetAsteroidsInfoQueryResult);

            groupAsteroidsByDayMock
                .Setup(c => c.Group(QueryMocks.GetAsteroidsInfoQueryResult))
                .Returns(QueryMocks.AsteroidsByDays);

            _getAsteroidsInfoQueryAsyncMock = getAsteroidsInfoQueryAsyncMock.Object;
            _groupAsteroidsByDay = groupAsteroidsByDayMock.Object;
        }

        [Test]
        public async Task ShouldReturnAsteroidsModel()
        {
            AsteroidsInfoService asteroidsInfoService = new AsteroidsInfoService(_getAsteroidsInfoQueryAsyncMock, _groupAsteroidsByDay);

            List<AsteroidsByDaysModel> actualObject = await asteroidsInfoService.GetAsteroidsInfoAsync(startDate, endDate);
            List<AsteroidsByDaysModel> expectedObject = QueryMocks.AsteroidsByDays;

            var actual = JsonConvert.SerializeObject(actualObject);
            var expected = JsonConvert.SerializeObject(expectedObject);

            Assert.AreEqual(actual, expected);
        }
    }
}