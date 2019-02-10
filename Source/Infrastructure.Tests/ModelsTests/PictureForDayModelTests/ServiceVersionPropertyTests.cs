using Infrastructure.Models;
using Infrastructure.Tests.Mocks.MockData;
using NUnit.Framework;

namespace Infrastructure.Tests.ModelsTests.PictureForDayModelTests
{
    [TestFixture]
    public class ServiceVersionPropertyTests
    {
        [Test]
        public void GetAndSetServiceVersion()
        {
            string expected = "v1";

            PictureForDayModel model = new PictureForDayModel(PictureInfoMock.GetPictureInfo, new byte[] { 123 });
            model.ServiceVersion = expected;

            string actual = model.ServiceVersion;

            Assert.AreEqual(actual, expected);
        }
    }
}