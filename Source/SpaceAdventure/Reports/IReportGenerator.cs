using System;
using System.Data;

namespace SpaceAdventure.Reports
{
    public interface IReportGenerator
    {
        void Generate(DataTable reportData, DateTime date, string folderPath);
    }
}
