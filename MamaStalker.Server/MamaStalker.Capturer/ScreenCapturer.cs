using MamaStalker.Capturer.Abstractions;
using System.Drawing;
using System.Windows.Forms;

namespace MamaStalker.Capturer
{
    public class ScreenCapturer : ICapture
    {
        public byte[] Capture()
        {
            var bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            Graphics g = Graphics.FromImage(bitmap);
            g.CopyFromScreen(0, 0, 0, 0, bitmap.Size);

            var imageConverter = new ImageConverter();
            return (byte[])imageConverter.ConvertTo(bitmap, typeof(byte[]));
        }
    }
}