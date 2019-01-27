using Core.Models.NeoFeedModels;
using System;
using System.Threading.Tasks;

namespace Infrastructure.APOD.Queries
{
    public interface IGetAsteroidsInfoQueryAsync
    {
        Task<AsteroidsInfo> ExecuteAsync(DateTime startDate, DateTime endDate);
    }
}