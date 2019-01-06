using DAL.APOD.Queries;
using DAL.Tests.Mocks.MockData;
using Infrastructure.APOD.Queries;
using Infrastructure.Context;
using Moq;
using NUnit.Framework;
using System.Threading.Tasks;

namespace DAL.Tests.APOD.Queries.GetPictureForDayQueryAsyncTests
{
    [TestFixture]
    public class ExecuteAsyncMethodTests
    {
        private readonly INasaContext _contextMock;

        public ExecuteAsyncMethodTests()
        {
            Mock<INasaContext> contextMock = new Mock<INasaContext>();

            contextMock.Setup(c => c.MakeByteArrayRequest(It.IsAny<string>())).ReturnsAsync(ResponseMocks.GetPictureMock);

            _contextMock = contextMock.Object;
        }

        [Test]
        public async Task ShouldReturnByteArray()
        {
            IGetPictureForDayQueryAsync getPictureForDayQueryAsync = new GetPictureForDayQueryAsync(_contextMock);

            byte[] actualObject = await getPictureForDayQueryAsync.ExecuteAsync("https://apod.nasa.gov/apod/image/1901/UT-blink_3d_a.gif");
            byte[] expectedObject = new byte[] { 123 };
            
            Assert.AreEqual(actualObject, expectedObject);
        }
    }
}
