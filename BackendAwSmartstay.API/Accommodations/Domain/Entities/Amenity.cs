namespace BackendAwSmartstay.API.Accommodations.Domain.Entities;

/// <summary>
/// Comodidad o servicio ofrecido por un alojamiento (WiFi, Piscina, Gimnasio, etc.)
/// </summary>
public class Amenity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string? Icon { get; set; }
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    // Navigation properties
    public virtual ICollection<AccommodationAmenity> AccommodationAmenities { get; set; } = new List<AccommodationAmenity>();
}