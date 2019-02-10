using NUnit.Framework;
using SpaceAdventure.Options;
using System;

namespace SpaceAdventure.Tests.Options.CliOptionsTests
{
    [TestFixture]
    public class DatePropertyTests
    {
        [Test]
        public void GetAndSetEndDate()
        {
            var expected = new DateTime(2015, 09, 08);

            CliOptions options = new CliOptions();
            options.Date = expected;

            var actual = options.Date;

            Assert.AreEqual(actual, expected);
        }
    }
}