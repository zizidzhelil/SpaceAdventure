using Infrastructure.Models;
using Infrastructure.Tests.Mocks.MockData;
using NUnit.Framework;

namespace Infrastructure.Tests.ModelsTests.PictureForDayModelTests
{
    [TestFixture]
    public class ExplanationPropertyTests
    {
        [Test]
        public void GetAndSetExplanation()
        {
            string expected = "Ultima Thule is the most distant world explored by a spacecraft from Earth.";

            PictureForDayModel model = new PictureForDayModel(PictureInfoMock.GetPictureInfo, new byte[] { 123 });
            model.Explanation = expected;

            string actual = model.Explanation;

            Assert.AreEqual(actual, expected);
        }
    }
}