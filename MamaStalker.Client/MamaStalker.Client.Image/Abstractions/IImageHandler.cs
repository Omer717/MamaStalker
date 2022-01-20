namespace MamaStalker.Client.Image.Abstractions
{
    public interface IImageHandler
    {
        void SaveBytesToImageFile(string name, byte[] data);
    }
}
