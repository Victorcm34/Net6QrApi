namespace Net6QrApi.Controllers { };

[ApiController]
[Route("api/[controller]")]

public class QrController : Controller
{
    private readonly IQrService _service;

    public QrController(IQrService service)
    {
        _service = service;
    }

    [HttpGet]
    public ActionResult GetImg([Required] string url)
    {
        return File(_service.GenByteArray(url), "image/jpg");
    }
}
