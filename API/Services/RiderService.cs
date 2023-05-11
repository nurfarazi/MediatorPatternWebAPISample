using API.Entity;

namespace API.Services;

public class RiderService
{
    public List<Rider> riders = new();
    public RiderService()
    {
        // Temporary data
        riders.Add(new Rider { Id = 1, Name = "Rider from constructor" });
    }

    public async Task<List<Rider>> CreateAsync(Rider rider, CancellationToken cancellationToken)
    {
        // Add a rider
        riders.Add(rider);
        // log the action
        Console.WriteLine("Rider created");
        
        return riders;
    }

    public List<Rider> GetAsync()
    {
        return riders;
    }

    public async Task<Rider> GetByIdAsync(int requestId)
    {
        throw new NotImplementedException();
    }
}