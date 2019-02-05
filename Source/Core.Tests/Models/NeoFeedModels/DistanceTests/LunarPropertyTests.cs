using Core.Models.NeoFeedModels;
using NUnit.Framework;

namespace Core.Tests.Models.NeoFeedModels.DistanceTests
{
    [TestFixture]
    public class LunarPropertyTests
    {
        [Test]
        public void GetAndSetLunar()
        {
            var expected = "12";

            Distance distance = new Distance();
            distance.Lunar = expected;

            var actual = distance.Lunar;

            Assert.AreEqual(actual, expected);
        }
    }
}