using Infrastructure.Models;
using Infrastructure.Tests.Mocks.MockData;
using NUnit.Framework;

namespace Infrastructure.Tests.ModelsTests.PictureForDayModelTests
{
    [TestFixture]
   public class MediaTypePropertyTests
    {
        [Test]
        public void GetAndSetMediaType()
        {
            string expected = "image";

            PictureForDayModel model = new PictureForDayModel(PictureInfoMock.GetPictureInfo, new byte[] { 123 });
            model.MediaType = expected;

            string actual = model.MediaType;

            Assert.AreEqual(actual, expected);
        }
    }
}