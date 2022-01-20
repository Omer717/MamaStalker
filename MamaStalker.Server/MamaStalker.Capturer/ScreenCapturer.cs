using MamaStalker.Capturer.Abstractions;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace MamaStalker.Capturer
{
    public class ScreenCapturer : ICapture
    {
        public byte[] Capture()
        {
            var bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            var imageConverter = new ImageConverter();
            return (byte[])imageConverter.ConvertTo(bitmap, typeof(byte[]));
        }
    }
}
