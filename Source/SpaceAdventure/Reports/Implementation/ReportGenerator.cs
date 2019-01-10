using Common.Constants;
using Infrastructure.Models;
using Infrastructure.Providers;
using SpaceAdventure.Writers;
using System.Data;
using System.IO;
using System.IO.Abstractions;

namespace SpaceAdventure.Reports.Implementation
{
    public class ReportGenerator : IReportGenerator
    {
        private readonly IDateTimeProvider _dateTimeProvider;
        private readonly ITextFileWriter _textFileWriter;
        private readonly IFileSystem _fileSystem;

        public ReportGenerator(
            IDateTimeProvider dateTimeProvider, 
            ITextFileWriter textFileWriter, 
            IFileSystem fileSystem)
        {
            _dateTimeProvider = dateTimeProvider;
            _textFileWriter = textFileWriter;
            _fileSystem = fileSystem;
        }

        public void Generate(DataTable reportData, PictureForDayModel pictureForDay, string folderPath)
        {
            string folderName = _dateTimeProvider.GetCurrentDateTime().ToString(CommonConstants.NasaApiDateFormat);
            string fileName = $"{folderName}.txt";

            string folderPathFull = Path.Combine(folderPath, folderName);
            string filePathFull = Path.Combine(folderPathFull, fileName);

            _fileSystem.Directory.CreateDirectory(folderPathFull);

            _textFileWriter.Write(reportData, filePathFull);
        }
    }
}
