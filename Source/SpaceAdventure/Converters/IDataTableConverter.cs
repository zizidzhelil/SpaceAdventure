using Infrastructure.Models;
using System.Data;

namespace SpaceAdventure.Converters
{
    public interface IDataTableConverter
    {
        DataTable ConvertPictureForDayToDataTable(PictureForDayModel pictureForDay);
    }
}
