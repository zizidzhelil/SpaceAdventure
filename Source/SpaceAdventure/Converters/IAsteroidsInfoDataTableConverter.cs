using Infrastructure.Models;
using System.Collections.Generic;
using System.Data;

namespace SpaceAdventure.Converters
{
    public interface IAsteroidsInfoDataTableConverter
    {
        DataTable ConvertAsteroidsToDataTable(List<AsteroidsByDaysModel> asteroidModel);
    }
}
