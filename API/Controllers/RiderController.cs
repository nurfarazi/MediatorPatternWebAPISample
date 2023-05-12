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
    public async Task<IActionResult> CreateAsync([FromBody] Rider rider)
    {
        await this.mediator.Send(new CreateRider.Command { Id = rider.Id });
        return Ok();
    }

    [HttpGet("{id}")]
    public async Task<Rider> GetByIdAsync(int id)
    {
        return await this.mediator.Send(new GetRiderById.Query { Id = id });
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int Id)
    {
        await this.mediator.Send(new DeleteRider.Command { Id = Id });
        return Ok();
    }
}