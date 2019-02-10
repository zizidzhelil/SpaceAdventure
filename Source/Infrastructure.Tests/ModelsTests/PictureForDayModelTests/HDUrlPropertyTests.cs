using Infrastructure.Models;
using Infrastructure.Tests.Mocks.MockData;
using NUnit.Framework;

namespace Infrastructure.Tests.ModelsTests.PictureForDayModelTests
{
    [TestFixture]
    class HDUrlPropertyTests
    {
        [Test]
        public void GetAndSetHDUrl()
        {
            string expected = "https://apod.nasa.gov/apod/image/1901/UT-blink_3d_a.gif";

            PictureForDayModel model = new PictureForDayModel(PictureInfoMock.GetPictureInfo, new byte[] { 123 });
            model.HDUrl = expected;

            string actual = model.HDUrl;

            Assert.AreEqual(actual, expected);
        }
    }
}