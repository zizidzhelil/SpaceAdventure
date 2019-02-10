using NUnit.Framework;
using SpaceAdventure.Options;
using System;

namespace SpaceAdventure.Tests.Options.CliOptionsTests
{
    [TestFixture]
    public class StartDatePropertyTests
    {
        [Test]
        public void GetAndSetStartDate()
        {
            var expected = new DateTime(2015, 09, 08);

            CliOptions options = new CliOptions();
            options.StartDate = expected;

            var actual = options.StartDate;

            Assert.AreEqual(actual, expected);
        }
    }
}
