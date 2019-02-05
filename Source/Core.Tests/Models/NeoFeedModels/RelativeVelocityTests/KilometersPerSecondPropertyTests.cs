using Core.Models.NeoFeedModels;
using NUnit.Framework;

namespace Core.Tests.Models.NeoFeedModels.RelativeVelocityTests
{
    [TestFixture]
    public class KilometersPerSecondPropertyTests
    {
        [Test]
        public void GetAndSetKilometersPerSecond()
        {
            var expected = "9.3";

            RelativeVelocity relativeVelocity = new RelativeVelocity();
            relativeVelocity.KilometersPerSecond = expected;

            var actual = relativeVelocity.KilometersPerSecond;

            Assert.AreEqual(actual, expected);
        }
    }
}