using MamaStalker.Client.Image.Abstractions;
using System.Drawing;
using System.IO;

namespace MamaStalker.Client.Image
{
    public class ByteConverter : IConverter
    {
        public Bitmap ConvertByteToBitmap(byte[] bytes)
        {
            using (var memoryStream = new MemoryStream(bytes))
            {
                return new Bitmap(memoryStream);
            }
        }
    }
}
