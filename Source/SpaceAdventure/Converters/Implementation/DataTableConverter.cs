using System.Data;
using Infrastructure.Models;

namespace SpaceAdventure.Converters.Implementation
{
    public class DataTableConverter : IDataTableConverter
    {
        public DataTable ConvertPictureForDayToDataTable(PictureForDayModel pictureForDay)
        {
            DataTable dataTable = new DataTable($"Picture for {pictureForDay.Date}");

            dataTable.Columns.Add("Parameters");
            dataTable.Columns.Add("Information");

            dataTable.Rows.Add("Title", pictureForDay.Title);
            dataTable.Rows.Add("Copyright", pictureForDay.Copyright);
            dataTable.Rows.Add("Media Type", pictureForDay.MediaType);
            dataTable.Rows.Add("Service Version", pictureForDay.ServiceVersion);          

            return dataTable;
        }
    }
}