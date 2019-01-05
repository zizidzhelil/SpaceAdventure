using Core.Models;

namespace Infrastructure.Models
{
    public class PictureForDayModel
    {
        public PictureForDayModel(PictureInfo pictureInfo, byte[] picture)
        {
            HDUrl = pictureInfo.HDUrl;
            Copyright = pictureInfo.Copyright;
            Date = pictureInfo.Date;
            Explanation = pictureInfo.Explanation;
            MediaType = pictureInfo.MediaType;
            ServiceVersion = pictureInfo.ServiceVersion;
            Title = pictureInfo.Title;
            Picture = picture;
        }

        public string HDUrl { get; set; }

        public string Copyright { get; set; }

        public string Date { get; set; }

        public string Explanation { get; set; }

        public string MediaType { get; set; }

        public string ServiceVersion { get; set; }

        public string Title { get; set; }

        public byte[] Picture { get; set; }
    }
}
