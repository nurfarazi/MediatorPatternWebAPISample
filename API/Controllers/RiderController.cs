using API.Entity;
using API.Handlers;
using API.Services;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RiderController : ControllerBase
{
    private RiderService _riderService;
    private readonly IMediator mediator;

    public RiderController(RiderService riderService, IMediator mediator)
    {
        _riderService = riderService;
        this.mediator = mediator;
    }

    [HttpGet]
    public async Task<List<Rider>> GetAsync()
    {
        return await mediator.Send(new GetRiders.Query());
    }
    
    [HttpPost]
    public IActionResult CreateAsync()
    {
        _riderService.Create();
        return Ok();
    }
    
    [HttpGet("{id}")]
    public async Task<Rider> GetByIdAsync(int id)
    {
        return await this.mediator.Send(new GetRiderById.Query { Id = id });
    }
}