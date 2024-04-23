using Microsoft.AspNetCore.Mvc;
using ReturnFileWebApi.Interfaces;

namespace ReturnFileWebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DownloadsController : ControllerBase
{
    private readonly IFileService _fileService;
    private const string MimeType = "img/png";
    private const string FileName = "Saturn.png";


    public DownloadsController(IFileService fileService)
    {
        _fileService = fileService;
    }

    [HttpGet("byte")]
    public ActionResult<byte[]> GetImageAsByteArray()
    {
        var image = _fileService.GetImageAsByteArray();
        return File(image, MimeType, FileName);
    }
}
