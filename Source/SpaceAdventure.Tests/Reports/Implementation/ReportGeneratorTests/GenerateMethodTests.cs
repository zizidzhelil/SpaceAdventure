using Common.Constants;
using Moq;
using NUnit.Framework;
using SpaceAdventure.Converters.Implementation;
using SpaceAdventure.Reports.Implementation;
using SpaceAdventure.Tests.Mocks.MockData;
using SpaceAdventure.Writers;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Abstractions;
using System.IO.Abstractions.TestingHelpers;

namespace SpaceAdventure.Tests.Reports.Implementation.ReportGeneratorTests
{
    [TestFixture]
    public class GenerateMethodTests
    {
        private readonly IFileSystem _fileSystemMock;
        private readonly ITextFileWriter _textFileWriterMock;
        private byte[] _file;

        public GenerateMethodTests()
        {
            Mock<IFileSystem> fileSystemMock = new Mock<IFileSystem>();
            Mock<ITextFileWriter> textFileWriterMock = new Mock<ITextFileWriter>();

            var fileSystem = new MockFileSystem(new Dictionary<string, MockFileData>
            {
                { $@"c:\demo\{new DateTime(2019, 01, 13).ToString(CommonConstants.NasaApiDateFormat)}", new MockFileData(new byte[] { 0x12, 0x34, 0x56, 0xd2})}
            });
            var dictionaryInfo = new MockDirectoryInfo(fileSystem, $@"c:\demo\{new DateTime(2019, 01, 13).ToString(CommonConstants.NasaApiDateFormat)}");

            fileSystemMock.Setup(f => f.Directory.CreateDirectory(It.IsAny<string>())).Returns(dictionaryInfo);

            textFileWriterMock.Setup(t => t.Write(It.IsAny<string>(), It.IsAny<DataTable>()))
                .Callback(() => _file = new byte[] { 123 });

            _fileSystemMock = fileSystemMock.Object;
            _textFileWriterMock = textFileWriterMock.Object;
        }

        [Test]
        public void ShouldGenerateTextFile()
        {
            ReportGenerator reportGenerator = new ReportGenerator(_fileSystemMock, _textFileWriterMock);

            DataTableConverter dataTableConverter = new DataTableConverter();
            var dataTable = dataTableConverter.ConvertPictureForDayToDataTable(PictureForDayModelMock.PictureForDayMock);

            reportGenerator.Generate(
                dataTable,
                new DateTime(2019, 01, 13),
                $@"c:\demo\");

            Assert.AreEqual(new byte[] { 123 }, _file);
        }
    }
}