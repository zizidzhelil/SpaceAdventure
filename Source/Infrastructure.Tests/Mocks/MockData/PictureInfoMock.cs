using Core.Models;

namespace Infrastructure.Tests.Mocks.MockData
{
    public class PictureInfoMock
    {
        public static readonly PictureInfo GetPictureInfo = new PictureInfo()
        {
            Copyright = "2019",
            Date = "2019-01-06",
            Explanation = "Ultima Thule is the most distant world explored by a spacecraft from Earth.",
            HDUrl = "https://apod.nasa.gov/apod/image/1901/UT-blink_3d_a.gif",
            MediaType = "image",
            ServiceVersion = "v1",
            Title = "Ultima Thule Rotation Gif",
            Url = "https://apod.nasa.gov/apod/image/1901/UT-blink_3d_a.gif"
        };
    }
}
