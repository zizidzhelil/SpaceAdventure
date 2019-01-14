using Common.Constants;
using Moq;
using NUnit.Framework;
using SpaceAdventure.Tests.Mocks.MockData;
using SpaceAdventure.Writers.Implementation;
using System;
using System.IO.Abstractions;
using System.IO.Abstractions.TestingHelpers;

namespace SpaceAdventure.Tests.Writers.Implementation.TextFileWriterTests
{
    [TestFixture]
    public class WriteMethodTests
    {
        private readonly IFileSystem _fileSystemMock;
        private readonly MockFileData _fileDataMock;

        public WriteMethodTests()
        {
            Mock<IFileSystem> fileSystemMock = new Mock<IFileSystem>();

            _fileDataMock = new MockFileData(string.Empty);

            fileSystemMock.Setup(f => f.File.WriteAllText(
                It.IsAny<string>(),
                It.IsAny<string>()))
                .Callback<string, string>((p, s) => _fileDataMock.TextContents = s);

            _fileSystemMock = fileSystemMock.Object;
        }

        [Test]
        public void WriteToFile()
        {
            TextFileWriter fileWriter = new TextFileWriter(_fileSystemMock);

            fileWriter.Write(
                $@"c:\demo\{new DateTime(2019, 01, 13).ToString(CommonConstants.NasaApiDateFormat)}",
                 DataTableMock.DataTableInfoMock());

            Assert.AreEqual(PictureForDayModelMock.GetFileInfoMock, _fileDataMock.TextContents);
        }
    }
}
