using FYP.Application.Common.Interfaces;
using FYP.Domain.Entities;
using MediatR;

namespace FYP.Application.Bookings;

public record CreateBooking() : IRequest<int>
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

public class CreateTodoItemCommandHandler : IRequestHandler<CreateBooking, int>
{
    private readonly IApplicationDbContext _context;

    public CreateTodoItemCommandHandler(IApplicationDbContext context)
    {
        _context = context; 
    }

    public async Task<int> Handle(CreateBooking request, CancellationToken cancellationToken)
    {
        var booking = new Booking()
        {
            ServiceName = request.ServiceName,
            Date = request.Date,
            Time = request.Time,
            FirstName = request.FirstName,
            LastName = request.LastName,
            PhoneNumber = request.PhoneNumber,
        };
        _context.Bookings.Add(booking);
        await _context.SaveChangesAsync(cancellationToken);
        return booking.Id;
    }
}