using API.Entity;
using API.Services;
using MediatR;

namespace API.Handlers;

public class GetRiderById
{
    public class Query : IRequest<Rider>
    {
        public int Id { get; set; }
    }
    
    public class QueryHandler : IRequestHandler<Query, Rider>
    {
        private readonly RiderService _riderService;

        public QueryHandler(RiderService riderService)
        {
            _riderService = riderService;
        }
        public async Task<Rider> Handle(Query request, CancellationToken cancellationToken)
        {
            return await _riderService.GetByIdAsync(request.Id);
        }
    }
}