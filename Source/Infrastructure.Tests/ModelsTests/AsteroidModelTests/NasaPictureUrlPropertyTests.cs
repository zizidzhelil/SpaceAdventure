using Infrastructure.Models;
using Infrastructure.Tests.Mocks.MockData;
using NUnit.Framework;

namespace Infrastructure.Tests.ModelsTests.AsteroidModelTests
{
    [TestFixture]
    public class NasaPictureUrlPropertyTests
    {
        [Test]
        public void GetAndSetNasaPictureUrl()
        {
            string expected = "http://ssd.jpl.nasa.gov/sbdb.cgi?sstr=3553060";

            AsteroidModel model = new AsteroidModel(AsteroidMock.GetAsteroid);
            model.NasaPictureUrl = expected;

            string actual = model.NasaPictureUrl;

            Assert.AreEqual(actual, expected);
        }
    }
}