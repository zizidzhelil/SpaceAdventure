using Infrastructure.Models;
using System.Data;

namespace SpaceAdventure.Reports
{
    public interface IReportGenerator
    {
        void Generate(DataTable reportData, PictureForDayModel pictureForDay, string folderPath);
    }
}
