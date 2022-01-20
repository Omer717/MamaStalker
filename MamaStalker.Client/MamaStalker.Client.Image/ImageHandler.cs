using MamaStalker.Client.Image.Abstractions;

namespace MamaStalker.Client.Image
{
    public class ImageHandler : IImageHandler
    {
        private readonly IConverter _converter;
        private readonly IImageSaver _imageSaver;

        public ImageHandler(IConverter converter, IImageSaver imageSaver)
        {
            _converter = converter;
            _imageSaver = imageSaver;
        }

        public void SaveBytesToImageFile(string name, byte[] data)
        {
            _imageSaver.SaveImage(name, _converter.ConvertByteToBitmap(data));
        }
    }
}
