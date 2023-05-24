using FYP.Application.Common.Interfaces;
using FYP.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FYP.Application.Bookings;

public record UpdateBooking : IRequest<int>
{
    public Booking Booking { get; init; }

}

public class UpdateBookingCommandHandler : IRequestHandler<UpdateBooking, int>
{
    private readonly IApplicationDbContext _context;

    public UpdateBookingCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(UpdateBooking request, CancellationToken cancellationToken)
    {
        var model = request.Booking;
        var booking = await _context.Bookings.FirstOrDefaultAsync(x => x.Id == request.Booking.Id, cancellationToken: cancellationToken);

        if (booking == null)
        {
            throw new Exception("Booking not found");
        }

        booking.Date = model.Date;
        booking.Price = model.Price;
        booking.FirstName = model.FirstName;
        booking.LastName = model.LastName;
        booking.PhoneNumber = model.PhoneNumber;
        booking.ServiceName = model.ServiceName;
        await _context.SaveChangesAsync(cancellationToken);
        return request.Booking.Id;
    }
}