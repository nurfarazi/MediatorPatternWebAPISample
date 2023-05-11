using API.Entity;
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
        public async Task<Rider> Handle(Query request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new Rider { Id = request.Id, Name = "Rider" });
        }
    }
}