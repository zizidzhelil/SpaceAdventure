using System.Collections.Generic;

namespace Infrastructure.Models
{
    public class AsteroidsByDaysModel
    {
        public string Date { get; set; }

        public List<AsteroidModel> Asteroids { get; set; }
    }
}
