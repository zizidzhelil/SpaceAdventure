using Infrastructure.Models;
using Infrastructure.Tests.Mocks.MockData;
using NUnit.Framework;

namespace Infrastructure.Tests.ModelsTests.PictureForDayModelTests
{
    [TestFixture]
    public class CopyrightPropertyTests
    {
        [Test]
        public void GetAndSetCopyright()
        {
            string expected = "2019";

            PictureForDayModel model = new PictureForDayModel(PictureInfoMock.GetPictureInfo, new byte[] { 123 });
            model.Copyright = expected;

            string actual = model.Copyright;

            Assert.AreEqual(actual, expected);
        }
    }
}