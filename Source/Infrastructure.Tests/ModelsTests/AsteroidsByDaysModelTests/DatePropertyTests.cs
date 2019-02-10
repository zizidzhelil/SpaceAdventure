using Infrastructure.Models;
using NUnit.Framework;

namespace Infrastructure.Tests.ModelsTests.AsteroidsByDaysModelTests
{
    [TestFixture]
    public class DatePropertyTests
    {
        [Test]
        public void GetAndSetDate()
        {
            var expected = "2019-02-10";

            AsteroidsByDaysModel model = new AsteroidsByDaysModel();
            model.Date = expected;

            var actual = model.Date;

            Assert.AreEqual(actual, expected);
        }
    }
}