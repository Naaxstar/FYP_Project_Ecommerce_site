namespace FYP.Domain.Entities;

public class Booking : BaseAuditableEntity
{
    public int Id { get; set; }

    public string Name { get; set; }

    public Decimal Price { get; set; }
}