using DAL.Context;
using DAL.Tests.Mocks;
using Moq;
using NUnit.Framework;
using System.Threading.Tasks;

namespace DAL.Tests.Context.NasaContextTests
{
    [TestFixture]
    public class MakeByteArrayRequestMethodTests
    {
        private const string Url = "https://api.nasa.gov/planetary/apod?date=2019-01-02&hd=true&api_key=DEMO_KEY";
        private readonly HttpClientFactoryMock _mockHttpClientFactory;

        public MakeByteArrayRequestMethodTests()
        {
            Mock<HttpClientFactoryMock> httpClientFactoryMock = new Mock<HttpClientFactoryMock>();
            Mock<HttpClientMock> httpClientMock = new Mock<HttpClientMock>();

            httpClientMock.Setup(s => s.GetStringAsync(It.IsAny<string>())).Returns(Task.FromResult("Mock text"));
            httpClientFactoryMock.Setup(s => s.CreateClient()).Returns(httpClientMock.Object);

            _mockHttpClientFactory = httpClientFactoryMock.Object;
        }

        [Test]
        public async Task ShouldReturnByteArray()
        {
            NasaContext context = new NasaContext(_mockHttpClientFactory);
            byte[] result = await context.MakeByteArrayRequest(Url);

            Assert.IsNotEmpty(result);
        }
    }
}
