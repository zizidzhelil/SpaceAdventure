using Core.Models.NeoFeedModels;
using NUnit.Framework;

namespace Core.Tests.Models.NeoFeedModels.KilometersTests
{
    [TestFixture]
    public class MinPropertyTests
    {
        [Test]
        public void GetAndSetMin()
        {
            var expected = 0.2;

            Kilometers kilometers = new Kilometers();
            kilometers.Min = expected;

            var actual = kilometers.Min;

            Assert.AreEqual(actual, expected);
        }
    }
}