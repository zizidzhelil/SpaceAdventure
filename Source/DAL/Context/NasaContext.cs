﻿using Infrastructure.Context;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class NasaContext : INasaContext
    {
        public async Task<string> MakeRequest(string url)
        {
            return "{\r\n\"copyright\": \"Francesco Antonucci\",\r\n\"date\": \"2019-01-02\",\r\n\"explanation\": \"The Great Nebula in Orion is an intriguing place.  Visible to the unaided eye, it appears as a small fuzzy patch in the constellation of Orion. But this image, an illusory-color four-panel mosaic taken in different bands of infrared light with the Earth orbiting WISE observatory, shows the Orion Nebula to be a bustling  neighborhood of recently formed stars, hot gas, and dark dust.  The power behind much of the Orion Nebula (M42) is the stars of the Trapezium star cluster, seen near the center of the featured image. The orange glow surrounding the bright stars pictured here is their own starlight reflected by intricate dust filaments that cover much of the region.  The current  Orion Nebula cloud complex, which includes the Horsehead Nebula, will slowly disperse over the next 100,000 years.   News: New Horizons Results from Ultima Thule\",\r\n\"hdurl\": \"https://apod.nasa.gov/apod/image/1901/orionred_WISEantonucci_1824.jpg\",\r\n\"media_type\": \"image\",\r\n\"service_version\": \"v1\",\r\n\"title\": \"The Orion Nebula in Infrared from WISE\",\r\n\"url\": \"https://apod.nasa.gov/apod/image/1901/orionred_WISEantonucci_960.jpg\"\r\n}";
        }
    }
}
