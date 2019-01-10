using System;

namespace Infrastructure.Providers
{
    public interface IDateTimeProvider
    {
        DateTime GetCurrentDateTime();
    }
}
