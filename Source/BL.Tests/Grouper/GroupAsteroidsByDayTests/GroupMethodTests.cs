using BL.Grouper;
using BL.Tests.Mocks.MockData;
using Infrastructure.Models;
using Newtonsoft.Json;
using NUnit.Framework;
using System.Collections.Generic;

namespace BL.Tests.Grouper.GroupAsteroidsByDayTests
{
    [TestFixture]
    public class GroupMethodTests
    {
        [Test]
        public void ShouldReturnValidAsteroidsForDays()
        {
            GroupAsteroidsByDay groupAsteroidsByDay = new GroupAsteroidsByDay();

            List<AsteroidsByDaysModel> actualObject = groupAsteroidsByDay.Group(QueryMocks.GetAsteroidsInfoQueryResult);
            List<AsteroidsByDaysModel> expectedObject = QueryMocks.AsteroidsByDays;

            var actual = JsonConvert.SerializeObject(actualObject);
            var expected = JsonConvert.SerializeObject(expectedObject);

            Assert.AreEqual(actual, expected);
        }
    }
}