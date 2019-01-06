using Common.Constants;
using DAL.Factories;
using DAL.Factories.ConcreteUrlBuilders;
using Infrastructure.Providers;
using Infrastructure.UrlFactory.UrlBuilder;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace DAL.Tests.Factories.UrlFactoryTests
{
    [TestFixture]
    public class CreateMethodTests
    {
        private readonly Dictionary<string, Func<IUrlBuilder>> _urlBuildersMock;
        private readonly string _apiKeyMock = Guid.NewGuid().ToString();

        public CreateMethodTests()
        {
            Mock<IAppSettingsProvider> appSettingsProviderMock = new Mock<IAppSettingsProvider>();
            appSettingsProviderMock.SetupGet(s => s.ApiKey).Returns(_apiKeyMock);

            _urlBuildersMock = new Dictionary<string, Func<IUrlBuilder>>()
            {
                { nameof(PictureInfoForDayUrlBuilder), () => new PictureInfoForDayUrlBuilder(appSettingsProviderMock.Object) }
            };
        }

        [Test]
        [TestCase("Class Name")]
        [TestCase("Class")]
        public void CreateMethodShouldThrowException(string builderName)
        {
            UrlFactory urlFactory = new UrlFactory(_urlBuildersMock);

            Assert.Throws<KeyNotFoundException>(() => urlFactory.Create(builderName));
        }

        [TestCase(nameof(PictureInfoForDayUrlBuilder))]
        public void CreateMethodShouldReturnUrlBuilder(string builderName)
        {
            UrlFactory urlFactory = new UrlFactory(_urlBuildersMock);

            string actual = urlFactory.Create(builderName, "2019-01-05");
            string expected = $"{CommonConstants.BaseSpaceAdventureUrl}?date=2019-01-05&hd=true&api_key={_apiKeyMock}";

            Assert.AreEqual(expected, actual);
        }
    }
}
