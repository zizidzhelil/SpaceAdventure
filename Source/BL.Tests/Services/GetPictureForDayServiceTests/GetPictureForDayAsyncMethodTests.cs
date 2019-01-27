using BL.Services;
using BL.Tests.Mocks.MockData;
using Infrastructure.APOD.Queries;
using Infrastructure.Models;
using Infrastructure.Services;
using Moq;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace BL.Tests.Services.GetPictureForDayServiceTests
{
    [TestFixture]
    public class GetPictureForDayAsyncMethodTests
    {
        private readonly IGetPictureInfoForDayQueryAsync _getPictureInfoForDayQueryAsyncMock;
        private readonly IGetPictureForDayQueryAsync _getPictureForDayQueryAsyncMock;

        public GetPictureForDayAsyncMethodTests()
        {
            Mock<IGetPictureInfoForDayQueryAsync> getPictureInfoForDayQueryAsyncMock = new Mock<IGetPictureInfoForDayQueryAsync>();
            Mock<IGetPictureForDayQueryAsync> getPictureForDayQueryAsyncMock = new Mock<IGetPictureForDayQueryAsync>();

            getPictureInfoForDayQueryAsyncMock
                .Setup(c => c.ExecuteAsync(It.IsAny<DateTime>()))
                .ReturnsAsync(QueryMocks.GetPictureInfoQueryResult);

            getPictureForDayQueryAsyncMock
                .Setup(c => c.ExecuteAsync(It.IsAny<string>()))
                .ReturnsAsync(new byte[] { 123 });

            _getPictureInfoForDayQueryAsyncMock = getPictureInfoForDayQueryAsyncMock.Object;
            _getPictureForDayQueryAsyncMock = getPictureForDayQueryAsyncMock.Object;
        }

        [Test]
        public async Task ShouldReturnPictureModel()
        {
            IPictureService pictureForDayService = new PictureService(
               _getPictureInfoForDayQueryAsyncMock,
               _getPictureForDayQueryAsyncMock);

            PictureForDayModel actualObject = await pictureForDayService.GetPictureForDayAsync(DateTime.Today);
            PictureForDayModel expectedObject = QueryMocks.PictureForDay;

            var actual = JsonConvert.SerializeObject(actualObject);
            var expected = JsonConvert.SerializeObject(expectedObject);

            Assert.AreEqual(actual, expected);
        }
    }
}
