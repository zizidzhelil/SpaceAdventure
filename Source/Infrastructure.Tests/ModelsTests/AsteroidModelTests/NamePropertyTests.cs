using Infrastructure.Models;
using Infrastructure.Tests.Mocks.MockData;
using NUnit.Framework;

namespace Infrastructure.Tests.ModelsTests.AsteroidModelTests
{
    [TestFixture]
    public class NamePropertyTests
    {
        [Test]
        public void GetAndSetName()
        {
            var expected = "asteroid";

            AsteroidModel model = new AsteroidModel(AsteroidMock.GetAsteroid);
            model.Name = expected;

            var actual = model.Name;

            Assert.AreEqual(actual, expected);
        }
    }
}
