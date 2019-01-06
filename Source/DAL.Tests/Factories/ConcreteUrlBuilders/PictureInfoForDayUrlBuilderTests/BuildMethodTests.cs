using Common.Constants;
using Infrastructure.Providers;
using DAL.Factories.ConcreteUrlBuilders;
using Moq;
using NUnit.Framework;
using System;

namespace DAL.Tests.Factories.ConcreteUrlBuilders.PictureInfoForDayUrlBuilderTests
{
    [TestFixture]
    public class BuildMethodTests
    {
        private readonly string _apiKeyMock = Guid.NewGuid().ToString();

        private readonly IAppSettingsProvider _appSettingsProviderMock;   

        public BuildMethodTests()
        {
            Mock<IAppSettingsProvider> appSettingsProviderMock = new Mock<IAppSettingsProvider>();

            appSettingsProviderMock.SetupGet(c => c.ApiKey).Returns(_apiKeyMock);

            _appSettingsProviderMock = appSettingsProviderMock.Object;
        }

        [Test]
        public void ShouldReturnUrlString()
        {
            PictureInfoForDayUrlBuilder urlBuilder = new PictureInfoForDayUrlBuilder(_appSettingsProviderMock);

            string actual = urlBuilder.Build("2019-01-05");
            string expected = $"{CommonConstants.BaseSpaceAdventureUrl}?date=2019-01-05&hd=true&api_key={_apiKeyMock}";

            Assert.AreEqual(expected, actual);
        }
    }
}
