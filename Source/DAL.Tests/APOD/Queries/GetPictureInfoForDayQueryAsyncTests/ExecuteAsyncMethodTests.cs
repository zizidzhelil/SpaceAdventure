using Core.Models;
using DAL.APOD.Queries;
using DAL.Factories.ConcreteUrlBuilders;
using DAL.Tests.Mocks.MockData;
using Infrastructure.APOD.Queries;
using Infrastructure.Context;
using Infrastructure.UrlFactory;
using Moq;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace DAL.Tests.APOD.Queries.GetPictureInfoForDayQueryAsyncTests
{
    [TestFixture]
    public class ExecuteAsyncMethodTests
    {
        private readonly INasaContext _contextMock;
        private readonly IUrlFactory _urlFactoryMock;

        public ExecuteAsyncMethodTests()
        {
            Mock<INasaContext> contextMock = new Mock<INasaContext>();
            Mock<IUrlFactory> urlFactoryMock = new Mock<IUrlFactory>();

            contextMock.Setup(c => c.MakeStringRequest(It.IsAny<string>())).ReturnsAsync(ResponseMocks.GetPictureInfoMock);
            urlFactoryMock
               .Setup(u => u.Create(nameof(PictureInfoForDayUrlBuilder), DateTime.Today.ToString()))
               .Returns($"https://api.nasa.gov/planetary/apod?date=2019-01-02&hd=true&api_key=DEMO_KEY");

            _contextMock = contextMock.Object;
            _urlFactoryMock = urlFactoryMock.Object;
        }

        [Test]
        public async Task ShouldReturnDeserializedObject()
        {
            IGetPictureInfoForDayQueryAsync getPictureInfoForDayQueryAsync = new GetPictureInfoForDayQueryAsync(_contextMock, _urlFactoryMock);

            PictureInfo actualObject = await getPictureInfoForDayQueryAsync.ExecuteAsync(DateTime.Today);
            PictureInfo expectedObject = JsonConvert.DeserializeObject<PictureInfo>(ResponseMocks.GetPictureInfoMock);

            var actual = JsonConvert.SerializeObject(actualObject);
            var expected = JsonConvert.SerializeObject(expectedObject);

            Assert.AreEqual(actual, expected);
        }
    }
}
