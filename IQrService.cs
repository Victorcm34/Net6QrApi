namespace Net6QrApi { };

public interface IQrService
{
    public byte[] GenByteArray(string url);
    public Bitmap GenImage(string url);
    public byte[] ImgToByte(Image img);
}
