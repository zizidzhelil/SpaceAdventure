using System.Collections.Generic;
using System.Data;
using System.Linq;
using Infrastructure.Models;

namespace SpaceAdventure.Converters.Implementation
{
    public class AsteroidsInfoDataTableConverter : IAsteroidsInfoDataTableConverter
    {
        public DataTable ConvertAsteroidsToDataTable(List<AsteroidsByDaysModel> asteroidsByDaysModel)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Parameters");
            dataTable.Columns.Add("Information");

            foreach (var asteroid in asteroidsByDaysModel.SelectMany(a => a.Asteroids))
            {
                dataTable.Rows.Add("Name", asteroid.Name);
                dataTable.Rows.Add("Nasa picture url", asteroid.NasaPictureUrl);
                dataTable.Rows.Add("Magnitute", asteroid.AbsoluteMagnitude);
                dataTable.Rows.Add("Estimated diameter in kilometers");
                dataTable.Rows.Add("  - Minimum", asteroid.EstimatedDiameter.Kilometers.Min);
                dataTable.Rows.Add("  - Maximum", asteroid.EstimatedDiameter.Kilometers.Max);
                dataTable.Rows.Add("Close approach info");
                dataTable.Rows.Add("  - Close approach date", asteroid.CloseApproachDate);
                dataTable.Rows.Add("  - Velocity");
                dataTable.Rows.Add("      * Kilometers per second", asteroid.RelativeVelocity.KilometersPerSecond);
                dataTable.Rows.Add("      * Kilometers per hour", asteroid.RelativeVelocity.KilometersPerHour);
                dataTable.Rows.Add("  - Miss distance");
                dataTable.Rows.Add("      * Kilometers", asteroid.MissDistance?.Kilometers);
                dataTable.Rows.Add("      * Astronomical", asteroid.MissDistance?.Astronomical);
                dataTable.Rows.Add("      * Lunar", asteroid.MissDistance?.Lunar);
                dataTable.Rows.Add("  - Orbiting body", asteroid.OrbitingBody);
                dataTable.Rows.Add();
            }

            return dataTable;
        }
    }
}