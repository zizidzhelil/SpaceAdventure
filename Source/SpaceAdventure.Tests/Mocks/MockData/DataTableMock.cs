using System.Data;

namespace SpaceAdventure.Tests.Mocks.MockData
{
    public static class DataTableMock
    {
        public static DataTable DataTableInfoMock()
        {
            DataTable dataTableMock = new DataTable();

            dataTableMock.Columns.Add("Parameters");
            dataTableMock.Columns.Add("Information");

            dataTableMock.Rows.Add("Title", "Partial Eclipse over Beijing");
            dataTableMock.Rows.Add("Copyright", "Li Zhaoqi");
            dataTableMock.Rows.Add("Media Type", "image");
            dataTableMock.Rows.Add("Service Version", "v1");

            return dataTableMock;
        }
    }
}
