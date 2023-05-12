using System.ComponentModel.DataAnnotations;

namespace API.Entity;

public class Rider
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = null!;
    [EmailAddress]
    public string Email { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string City { get; set; } = null!;
    public string State { get; set; } = null!;
    public string Zip { get; set; } = null!;
}