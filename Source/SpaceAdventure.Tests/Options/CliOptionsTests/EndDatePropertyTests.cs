using NUnit.Framework;
using SpaceAdventure.Options;
using System;

namespace SpaceAdventure.Tests.Options.CliOptionsTests
{
    [TestFixture]
    public class EndDatePropertyTests
    {
        [Test]
        public void GetAndSetEndDate()
        {
            var expected = new DateTime(2015, 09, 08);

            CliOptions options = new CliOptions();
            options.EndDate = expected;

            var actual = options.EndDate;

            Assert.AreEqual(actual, expected);
        }
    }
}