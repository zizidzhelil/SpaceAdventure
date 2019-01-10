using Infrastructure.Providers;
using System;

namespace SpaceAdventure.Providers
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime GetCurrentDateTime()
        {
            return DateTime.Now;
        }
    }
}
