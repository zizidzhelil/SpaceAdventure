using Core.Models.NeoFeedModels;
using NUnit.Framework;

namespace Core.Tests.Models.NeoFeedModels.CloseApproachDataTests
{
    [TestFixture]
    public class EpochDateCloseApproachPropertyTests
    {
        [Test]
        public void GetAndSetEpochDateCloseApproach()
        {
            var expected = new object();

            CloseApproachData closeApproachData = new CloseApproachData();
            closeApproachData.EpochDateCloseApproach = expected;

            var actual = closeApproachData.EpochDateCloseApproach;

            Assert.AreEqual(actual, expected);
        }
    }
}