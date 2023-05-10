using API.Entity;

namespace API.Services;

public class RiderService
{
    public List<Rider> riders = new List<Rider>();
    public RiderService()
    {
        // Temporary data
        riders.Add(new Rider { Id = 1, Name = "Rider from constructor" });
    }

    public void Create()
    {
        // Add a rider
        riders.Add(new Rider { Id = 1, Name = "Rider 1" });
        // log the action
        Console.WriteLine("Rider created");
    }

    public List<Rider> GetAsync()
    {
        return riders;
    }
}