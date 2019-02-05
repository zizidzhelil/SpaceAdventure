using Core.Models.NeoFeedModels;
using NUnit.Framework;

namespace Core.Tests.Models.NeoFeedModels.KilometersTests
{
    [TestFixture]
    public class MaxPropertyTests
    {
        [Test]
        public void GetAndSetMin()
        {
            var expected = 9.3;

            Kilometers kilometers = new Kilometers();
            kilometers.Max = expected;

            var actual = kilometers.Max;

            Assert.AreEqual(actual, expected);
        }
    }
}