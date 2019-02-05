using Core.Models.NeoFeedModels;
using NUnit.Framework;

namespace Core.Tests.Models.NeoFeedModels.CloseApproachDataTests
{
    [TestFixture]
    public class MissDistancePropertyTests
    {
        [Test]
        public void GetAndSetMissDistance()
        {
            var expected = new Distance
            {
                Astronomical = "12",
                Lunar = "3",
                Kilometers = "5"
            };

            CloseApproachData closeApproachData = new CloseApproachData();
            closeApproachData.MissDistance = expected;

            var actual = closeApproachData.MissDistance;

            Assert.AreEqual(actual, expected);
        }
    }
}