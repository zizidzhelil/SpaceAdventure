using Common.Constants;
using DAL.Factories.ConcreteUrlBuilders;
using Infrastructure.Providers;
using Moq;
using NUnit.Framework;
using System;

namespace DAL.Tests.Factories.ConcreteUrlBuilders.GetAsteroidsInfoUrlBuilderTests
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
            GetAsteroidsInfoUrlBuilder urlBuilder = new GetAsteroidsInfoUrlBuilder(_appSettingsProviderMock);

            string actual = urlBuilder.Build("2019-01-05", "2019-01-06");
            string expected = $"{CommonConstants.BaseAsteroidsInfoUrl}?start_date=2019-01-05&end_date=2019-01-06&api_key={_apiKeyMock}"; 

            Assert.AreEqual(expected, actual);
        }
    }
}