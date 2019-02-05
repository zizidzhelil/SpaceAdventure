using NUnit.Framework;
using SpaceAdventure.Converters.Implementation;
using SpaceAdventure.Tests.Mocks.MockData;
using System.Data;

namespace SpaceAdventure.Tests.Converters.Implementation.DataTableConverterTests
{
    [TestFixture]
    public class ConvertAsteroidsToDataTableMethodTests
    {
        private DataTable dataTable;

        public ConvertAsteroidsToDataTableMethodTests()
        {
            AsteroidsInfoDataTableConverter dataTableConverter = new AsteroidsInfoDataTableConverter();
            dataTable = dataTableConverter.ConvertAsteroidsToDataTable(AsteroidsByDaysModelMock.AsteroidsByDaysModelMocks);
        }

        [Test]
        public void ConvertAsteroidsToDataTableColumnTest()
        {
            Assert.AreEqual(dataTable.Columns[0].ColumnName, "Parameters");
            Assert.AreEqual(dataTable.Columns[1].ColumnName, "Information");
        }

        [Test]
        public void ShouldReturnDataTable()
        {
            AsteroidsInfoDataTableConverter converter = new AsteroidsInfoDataTableConverter();

            var expected = AsteroidsByDaysModelMock.AsteroidsByDaysModelMocks;
            DataTable actual = converter.ConvertAsteroidsToDataTable(expected);

            Assert.AreEqual(actual.Columns.Count, 2);
        }
    }
}
