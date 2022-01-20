using System.Drawing;

namespace MamaStalker.Client.Image.Abstractions
{
    public interface IConverter
    {
        Bitmap ConvertByteToBitmap(byte[] bytes);
    }
}
