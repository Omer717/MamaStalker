using MamaStalker.Client.Image.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MamaStalker.Client.Image
{
    public class JpgImageSaver : IImageSaver
    {
        private const string DIRECTORY = @"/ScreenShots/";
        public void SaveImage(string name, Bitmap bitmapImage)
        {
            bitmapImage.Save($"{DIRECTORY + name}.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
