using Infrastructure.Models;
using System;
using System.Data;

namespace SpaceAdventure.Reports
{
    public interface IReportGenerator
    {
        void Generate(DataTable reportData, PictureForDayModel pictureForDay, DateTime pictureDate, string folderPath);
    }
}
