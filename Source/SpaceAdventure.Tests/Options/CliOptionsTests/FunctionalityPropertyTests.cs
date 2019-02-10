using NUnit.Framework;
using SpaceAdventure.Options;

namespace SpaceAdventure.Tests.Options.CliOptionsTests
{
    [TestFixture]
    public class FunctionalityPropertyTests
    {
        [Test]
        public void GetAndSetFunctionality()
        {
            var expected = "Picture info";

            CliOptions options = new CliOptions();
            options.Functionality = expected;

            var actual = options.Functionality;

            Assert.AreEqual(actual, expected);
        }
    }
}
