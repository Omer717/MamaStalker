using System.Drawing;

namespace MamaStalker.Client.Image.Abstractions
{
    public interface IImageSaver
    {
        void SaveImage(string name, Bitmap bitmapImage);
    }
}
