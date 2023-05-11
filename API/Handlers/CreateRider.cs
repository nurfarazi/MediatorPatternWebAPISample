using System.ComponentModel.DataAnnotations;
using API.Entity;
using API.Services;
using Bogus;
using MediatR;

namespace API.Handlers;

public class CreateRider
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
            var rider = new Faker<Rider>()
                .RuleFor(r => r.Id, f => f.Random.Number(1, 100))
                .RuleFor(r => r.Name, f => f.Name.FullName());

            await _riderService.CreateAsync(rider, cancellationToken);

            return request.Id;
        }
    }
}