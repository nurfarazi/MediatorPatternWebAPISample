using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class RiderController : ControllerBase
{
    private readonly ILogger<RiderController> _logger;
    private RiderService _riderService;

    public RiderController(ILogger<RiderController> logger, RiderService riderService)
    {
        _logger = logger;
        _riderService = riderService;
    }

    [HttpGet]
    public IActionResult GetAsync()
    {
        _riderService.GetAsync();
        return Ok();
    }
    
    [HttpPost]
    public IActionResult CreateAsync()
    {
        _riderService.Create();
        return Ok();
    }
}