using Core.Models;
using Infrastructure.Models;

namespace BL.Tests.Mocks.MockData
{
    public class QueryMocks
    {
        public static readonly PictureInfo GetPictureInfoQueryResult = new PictureInfo()
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

        public static readonly PictureForDayModel PictureForDay = new PictureForDayModel(GetPictureInfoQueryResult, new byte[] { 123 });
    }
}
