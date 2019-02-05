using Core.Models.NeoFeedModels;
using NUnit.Framework;

namespace Core.Tests.Models.NeoFeedModels.DistanceTests
{
    [TestFixture]
    public class AstronomicalPropertyTests
    {
        [Test]
        public void GetAndSetAstronomical()
        {
            var expected = "12";

            Distance distance = new Distance();
            distance.Astronomical = expected;

            var actual = distance.Astronomical;

            Assert.AreEqual(actual, expected);
        }
    }
}