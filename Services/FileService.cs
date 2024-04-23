using ReturnFileWebApi.Interfaces;

namespace ReturnFileWebApi.Services;

public class FileService : IFileService
{
    public byte[] GetImageAsByteArray()
    {
        return ConvertImageToByteArrayAsync();
    }

    private byte[] ConvertImageToByteArrayAsync()
    {
        var directory = Directory.GetCurrentDirectory();
        var path = Path.Combine(directory, "Assets", "Saturn.png");

        return File.ReadAllBytes(path);
    }
}