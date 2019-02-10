using Infrastructure.Models;
using Infrastructure.Tests.Mocks.MockData;
using NUnit.Framework;

namespace Infrastructure.Tests.ModelsTests.PictureForDayModelTests
{
    [TestFixture]
    public class TitlePropertyTests
    {
        [Test]
        public void GetAndSetTitle()
        {
            string expected = "Ultima Thule Rotation Gif";

            PictureForDayModel model = new PictureForDayModel(PictureInfoMock.GetPictureInfo, new byte[] { 123 });
            model.Title = expected;

            string actual = model.Title;

            Assert.AreEqual(actual, expected);
        }
    }
}