using Core.Models.NeoFeedModels;
using NUnit.Framework;

namespace Core.Tests.Models.NeoFeedModels.CloseApproachDataTests
{
    [TestFixture]
    public class OrbitingBodyPropertyTests
    {
        [Test]
        public void GetAndSetOrbitingBody()
        {
            var expected = "bodyTest";

            CloseApproachData closeApproachData = new CloseApproachData();
            closeApproachData.EpochDateCloseApproach = expected;

            var actual = closeApproachData.EpochDateCloseApproach;

            Assert.AreEqual(actual, expected);
        }
    }
}