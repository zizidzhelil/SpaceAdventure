using Core.Models.NeoFeedModels;
using Infrastructure.Models;
using Infrastructure.Tests.Mocks.MockData;
using NUnit.Framework;

namespace Infrastructure.Tests.ModelsTests.AsteroidModelTests
{
    [TestFixture]
    public class EstimatedDiameterPropertyTests
    {
        [Test]
        public void GetAndSetEstimatedDiameter()
        {
            var expected = new Diameter
            {
                Kilometers = new Kilometers
                {
                    Min = 0.1,
                    Max = 6.3
                }
            };

            AsteroidModel model = new AsteroidModel(AsteroidMock.GetAsteroid);
            model.EstimatedDiameter = expected;

            var actual = model.EstimatedDiameter;

            Assert.AreEqual(actual, expected);
        }
    }
}