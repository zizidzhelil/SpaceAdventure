using NUnit.Framework;
using SpaceAdventure.Converters.Implementation;
using SpaceAdventure.Tests.Mocks.MockData;
using System.Data;

namespace SpaceAdventure.Tests.Converters.Implementation.DataTableConverterTests
{
    [TestFixture]
    public class ConvertPictureForDayToDataTableMethodTests
    {
        private DataTable dataTable;

        [SetUp]
        public void Setup()
        {
            DataTableConverter dataTableConverter = new DataTableConverter();
            dataTable = dataTableConverter.ConvertPictureForDayToDataTable(PictureForDayModelMock.PictureForDayMock);
        }

        [Test]
        public void ConvertPictureForDayToDataTableColumnTest()
        {      
            Assert.AreEqual(dataTable.Columns[0].ColumnName, "Parameters");
            Assert.AreEqual(dataTable.Columns[1].ColumnName, "Information");
        }

        [Test]
        public void ConvertPictureForDayToDataTableRowTest()
        {
            Assert.AreEqual(dataTable.Rows[0].ItemArray[0], "Title");
            Assert.AreEqual(dataTable.Rows[0].ItemArray[1], "Partial Eclipse over Beijing");

            Assert.AreEqual(dataTable.Rows[1].ItemArray[0], "Copyright");
            Assert.AreEqual(dataTable.Rows[1].ItemArray[1], "Li Zhaoqi");

            Assert.AreEqual(dataTable.Rows[2].ItemArray[0], "Media Type");
            Assert.AreEqual(dataTable.Rows[2].ItemArray[1], "image");

            Assert.AreEqual(dataTable.Rows[3].ItemArray[0], "Service Version");
            Assert.AreEqual(dataTable.Rows[3].ItemArray[1], "v1");
        }
    }
}