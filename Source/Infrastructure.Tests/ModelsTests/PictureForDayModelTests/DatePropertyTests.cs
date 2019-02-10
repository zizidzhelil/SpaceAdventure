using Infrastructure.Models;
using Infrastructure.Tests.Mocks.MockData;
using NUnit.Framework;

namespace Infrastructure.Tests.ModelsTests.PictureForDayModelTests
{
    [TestFixture]
    public class DatePropertyTests
    {
        [Test]
        public void GetAndSetDate()
        {
            string expected = "2019-01-04";

            PictureForDayModel model = new PictureForDayModel(PictureInfoMock.GetPictureInfo, new byte[] { 123 });
            model.Date = expected;

            string actual = model.Date;

            Assert.AreEqual(actual, expected);
        }
    }
}