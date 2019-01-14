using Core.Models;
using Infrastructure.Models;
using System;

namespace SpaceAdventure.Tests.Mocks.MockData
{
    public class PictureForDayModelMock
    {
        public static readonly PictureForDayModel PictureForDayMock = new PictureForDayModel(new PictureInfo()
        {
            Copyright = "Li Zhaoqi",
            Date = DateTime.Now.Date.ToString("yyyy-MM-dd"),
            Explanation = "The New Moon rose in silhouette with the Sun seen from northeastern Asia.",
            HDUrl = "https://apod.nasa.gov/apod/image/1901/Beijing_pse-s.jpg",
            MediaType = "image",
            ServiceVersion = "v1",
            Title = "Partial Eclipse over Beijing",
            Url = "https://apod.nasa.gov/apod/image/1901/Beijing_pse-c1024.jpg"
        }, new byte[] { 123 });

        public static readonly string GetFileInfoMock = "Title: Partial Eclipse over Beijing\r\nCopyright: Li Zhaoqi\r\nMedia Type: image\r\nService Version: v1\r\n";
    }
}