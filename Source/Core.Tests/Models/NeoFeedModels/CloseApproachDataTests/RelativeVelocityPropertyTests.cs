using Core.Models.NeoFeedModels;
using NUnit.Framework;

namespace Core.Tests.Models.NeoFeedModels.CloseApproachDataTests
{
    [TestFixture]
    public class RelativeVelocityPropertyTests
    {
        [Test]
        public void GetAndSetRelativeVelocity()
        {
            var expected = new RelativeVelocity
            {
                KilometersPerSecond = "12",
                KilometersPerHour = "120000"
            };

            CloseApproachData closeApproachData = new CloseApproachData();
            closeApproachData.RelativeVelocity = expected;

            var actual = closeApproachData.RelativeVelocity;

            Assert.AreEqual(actual, expected);
        }
    }
}