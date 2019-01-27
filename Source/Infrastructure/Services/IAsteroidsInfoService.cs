using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public interface IAsteroidsInfoService
    {
        Task<List<AsteroidsByDaysModel>> GetAsteroidsInfoAsync(DateTime startDate, DateTime endDate);
    }
}