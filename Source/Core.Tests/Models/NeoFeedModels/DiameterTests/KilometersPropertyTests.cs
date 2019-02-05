using Core.Models.NeoFeedModels;
using NUnit.Framework;

namespace Core.Tests.Models.NeoFeedModels.DiameterTests
{
    [TestFixture]
    public class KilometersPropertyTests
    {
        [Test]
        public void GetAndSetKilometers()
        {
            var expected = new Kilometers
            {
                Min = 0.2,
                Max = 6.9
            };

            Diameter diameter = new Diameter();
            diameter.Kilometers = expected;

            var actual = diameter.Kilometers;

            Assert.AreEqual(actual, expected);
        }
    }
}