using Common.Constants;
using Infrastructure.Models;
using SpaceAdventure.Writers;
using System;
using System.Data;
using System.IO;
using System.IO.Abstractions;

namespace SpaceAdventure.Reports.Implementation
{
    public class ReportGenerator : IReportGenerator
    {
        private readonly IFileSystem _fileSystem;
        private readonly ITextFileWriter _textFileWriter;      

        public ReportGenerator(IFileSystem fileSystem, ITextFileWriter textFileWriter)
        {
            _fileSystem = fileSystem;
            _textFileWriter = textFileWriter;          
        }

        public void Generate(DataTable reportData, DateTime date, string folderPath)
        {
            string folderName = date.ToString(CommonConstants.NasaApiDateFormat);
            string fileName = $"{folderName}.txt";

            string folderPathFull = Path.Combine(folderPath, folderName);
            string filePathFull = Path.Combine(folderPathFull, fileName);

            _fileSystem.Directory.CreateDirectory(folderPathFull);

            _textFileWriter.Write(filePathFull, reportData);
        }
    }
}