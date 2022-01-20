using MamaStalker.Client.Image.Abstractions;
using System.Drawing;

namespace MamaStalker.Client.Image
{
    public class JpgImageSaver : IImageSaver
    {
        public void SaveImage(string name, Bitmap bitmapImage)
        {
            bitmapImage.Save($"{name}.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
