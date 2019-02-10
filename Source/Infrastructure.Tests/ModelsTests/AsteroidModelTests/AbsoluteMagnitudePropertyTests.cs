using Infrastructure.Models;
using Infrastructure.Tests.Mocks.MockData;
using NUnit.Framework;

namespace Infrastructure.Tests.ModelsTests.AsteroidModelTests
{
    [TestFixture]
    public class AbsoluteMagnitudePropertyTests
    {
        [Test]
        public void GetAndSetAbsoluteMagnitude()
        {
            double expected = 0.245;

            AsteroidModel model = new AsteroidModel(AsteroidMock.GetAsteroid);
            model.AbsoluteMagnitude = expected;

            double actual = model.AbsoluteMagnitude;

            Assert.AreEqual(actual, expected);
        }    
    }
}