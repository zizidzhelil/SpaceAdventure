using Core.Models.NeoFeedModels;
using NUnit.Framework;

namespace Core.Tests.Models.NeoFeedModels.CloseApproachDataTests
{
    [TestFixture]
    public class CloseApproachDatePropertyTests
    {
        [Test]
        public void GetAndSetCloseApproachDate()
        {
            string expected = "2019-01-20";

            CloseApproachData closeApproachData = new CloseApproachData();
            closeApproachData.CloseApproachDate = expected;

            string actual = closeApproachData.CloseApproachDate;

            Assert.AreEqual(actual, expected);
        }
    }
}