using Core.Models.NeoFeedModels;
using NUnit.Framework;

namespace Core.Tests.Models.NeoFeedModels.DistanceTests
{
    [TestFixture]
    public class KilometersPropertyTests
    {
        [Test]
        public void GetAndSetKilometers()
        {
            var expected = "12";

            Distance distance = new Distance();
            distance.Kilometers = expected;

            var actual = distance.Kilometers;

            Assert.AreEqual(actual, expected);
        }
    }
}