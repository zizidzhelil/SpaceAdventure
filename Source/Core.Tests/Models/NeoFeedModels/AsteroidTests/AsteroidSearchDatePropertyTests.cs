using Core.Models.NeoFeedModels;
using NUnit.Framework;
using System;

namespace Core.Tests.Models.NeoFeedModels.AsteroidTests
{
    [TestFixture]
    public class AsteroidSearchDatePropertyTests
    {
        [Test]
        public void GetAndSetAsteroidSearchDate()
        {
            DateTime expected = new DateTime(2015, 09, 08);

            Asteroid asteroid = new Asteroid();
            asteroid.AsteroidSearchDate = expected;

            DateTime actual = asteroid.AsteroidSearchDate;

            Assert.AreEqual(actual, expected);
        }
    }
}