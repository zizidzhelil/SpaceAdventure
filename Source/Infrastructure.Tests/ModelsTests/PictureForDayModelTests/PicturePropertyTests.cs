using Infrastructure.Models;
using Infrastructure.Tests.Mocks.MockData;
using NUnit.Framework;

namespace Infrastructure.Tests.ModelsTests.PictureForDayModelTests
{
    [TestFixture]
    public class PicturePropertyTests
    {
        [Test]
        public void GetAndSetTitle()
        {
            var expected = new byte[] { 123 };

            PictureForDayModel model = new PictureForDayModel(PictureInfoMock.GetPictureInfo, new byte[] { 123 });
            model.Picture = expected;

            var actual = model.Picture;

            Assert.AreEqual(actual, expected);
        }
    }
}