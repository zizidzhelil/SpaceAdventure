using Core.Models.NeoFeedModels;
using NUnit.Framework;

namespace Core.Tests.Models.NeoFeedModels.RelativeVelocityTests
{
    [TestFixture]
    public class KilometersPerHourPropertyTests
    {
        [Test]
        public void GetAndSetKilometersPerHour()
        {
            var expected = "9.3";

            RelativeVelocity relativeVelocity = new RelativeVelocity();
            relativeVelocity.KilometersPerHour = expected;

            var actual = relativeVelocity.KilometersPerHour;

            Assert.AreEqual(actual, expected);
        }
    }
}