using API.Entity;
using API.Services;
using MediatR;

namespace API.Handlers;

public class GetRiders
{
    public class Query : IRequest<List<Rider>>
    {
    }
    
    public class QueryHandler : IRequestHandler<Query, List<Rider>>
    {
        private readonly RiderService riderService;

        public QueryHandler(RiderService riderService)
        {
            this.riderService = riderService;
        }
        public async Task<List<Rider>> Handle(Query request, CancellationToken cancellationToken)
        {
            Console.WriteLine("GetRiders.QueryHandler.Handle");
            return this.riderService.GetAsync();
        }
    }
}