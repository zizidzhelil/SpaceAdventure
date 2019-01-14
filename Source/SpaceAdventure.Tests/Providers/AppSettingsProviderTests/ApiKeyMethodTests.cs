using Common.Constants;
using Microsoft.Extensions.Configuration;
using Moq;
using NUnit.Framework;
using SpaceAdventure.Providers;
using System;

namespace SpaceAdventure.Tests.Providers.AppSettingsProviderTests
{
    [TestFixture]
    public class ApiKeyMethodTests
    {
        private readonly IConfigurationRoot _configurationRootMock;
        private readonly string _apiKeyMock = Guid.NewGuid().ToString();

        public ApiKeyMethodTests()
        {
            Mock<IConfigurationRoot> configurationRootMock = new Mock<IConfigurationRoot>();
            configurationRootMock.SetupGet(c => c[AppSettingsConstants.SpaceAdventureKey]).Returns(_apiKeyMock);

            _configurationRootMock = configurationRootMock.Object;
        }

        [Test]
        public void ShouldReturnApiKey()
        {
            AppSettingsProvider appSettingsProvider = new AppSettingsProvider(_configurationRootMock);

            string actual = appSettingsProvider.ApiKey;
            string expected = _apiKeyMock;

            Assert.AreEqual(expected, actual);
        }
    }
}