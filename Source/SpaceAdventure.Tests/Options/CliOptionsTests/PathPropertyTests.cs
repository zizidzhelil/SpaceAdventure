using NUnit.Framework;
using SpaceAdventure.Options;

namespace SpaceAdventure.Tests.Options.CliOptionsTests
{
    [TestFixture]
    public class PathPropertyTests
    {
        [Test]
        public void GetAndSetPath()
        {
            var expected = "C:\\Desktop\\SpaceAdventure";

            CliOptions options = new CliOptions();
            options.Path = expected;

            var actual = options.Path;

            Assert.AreEqual(actual, expected);
        }
    }
}