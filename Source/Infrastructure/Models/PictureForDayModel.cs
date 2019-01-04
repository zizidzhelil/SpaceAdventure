using Core.Models;

namespace Infrastructure.Models
{
    public class PictureForDayModel
    {
        public PictureForDayModel(PictureInfo picture)
        {
            Url = picture.Url;
        }

        public string Url { get; set; }
    }
}
