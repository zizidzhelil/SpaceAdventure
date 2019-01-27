using Core.Models.NeoFeedModels;
using Infrastructure.Models;
using System;
using System.Collections.Generic;

namespace Infrastructure.Grouper
{
    public interface IGroupAsteroidsByDay
    {
        List<AsteroidsByDaysModel> Group(AsteroidsInfo asteroidsInfo);
    }
}
