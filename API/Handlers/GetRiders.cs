using API.Entity;
using MediatR;

namespace API.Handlers;

public class GetRiders
{
    public class Query : IRequest<List<Rider>>
    {
    }
    
    public class QueryHandler : IRequestHandler<Query, List<Rider>>
    {
        public async Task<List<Rider>> Handle(Query request, CancellationToken cancellationToken)
        {
            Console.WriteLine("GetRiders.QueryHandler.Handle");
            return new List<Rider>();
        }
    }
}