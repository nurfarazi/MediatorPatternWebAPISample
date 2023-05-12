using API.Entity;
using API.Services;
using Bogus;
using MediatR;

namespace API.Handlers;

public class DeleteRider
{
    public class Command : IRequest<int>
    {
        public int Id { get; set; }
    }
    
    public class CommandHandler : IRequestHandler<Command, int>
    {
        private readonly RiderService _riderService;

        public CommandHandler(RiderService riderService)
        {
            _riderService = riderService;
        }

        public async Task<int> Handle(Command request, CancellationToken cancellationToken)
        {
            Console.WriteLine($"DeleteRider: {request.Id}");
            await _riderService.DeleteAsync(request.Id, cancellationToken);

            return request.Id;
        }
    }
    
}