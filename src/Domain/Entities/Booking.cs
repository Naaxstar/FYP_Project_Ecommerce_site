namespace FYP.Domain.Entities;

public class Booking : BaseAuditableEntity
{
    public int Id { get; set; }
    public string ServiceName { get; set; }
    public Decimal Price { get; set; }
    public string Date { get; set; }
    public string Time { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
}