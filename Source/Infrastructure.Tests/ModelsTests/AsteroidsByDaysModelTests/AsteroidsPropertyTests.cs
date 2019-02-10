using Infrastructure.Models;
using Infrastructure.Tests.Mocks.MockData;
using NUnit.Framework;
using System.Collections.Generic;

namespace Infrastructure.Tests.ModelsTests.AsteroidsByDaysModelTests
{
    [TestFixture]
    public class AsteroidsPropertyTests
    {
        [Test]
        public void GetAndSetDate()
        {
            var expected = new List<AsteroidModel>
            {
                new AsteroidModel(AsteroidMock.GetAsteroid)
                {
                    Name = AsteroidMock.GetAsteroid.Name,
                    NasaPictureUrl = AsteroidMock.GetAsteroid.NasaPictureUrl,
                    AbsoluteMagnitude = AsteroidMock.GetAsteroid.AbsoluteMagnitude,
                    EstimatedDiameter = AsteroidMock.GetAsteroid.EstimatedDiameter,
                    CloseApproachData =  AsteroidMock.GetAsteroid.CloseApproachData
                }
            };

            AsteroidsByDaysModel model = new AsteroidsByDaysModel();
            model.Asteroids = expected;

            var actual = model.Asteroids;

            Assert.AreEqual(actual, expected);
        }
    }
}