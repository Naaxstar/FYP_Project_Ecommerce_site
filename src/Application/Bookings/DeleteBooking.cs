using FYP.Application.Common.Exceptions;
using FYP.Application.Common.Interfaces;
using FYP.Application.TodoItems.Commands.DeleteTodoItem;
using FYP.Domain.Events;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection.Bookings;

public record DeleteBooking(int Id) : IRequest;

public class DeleteBookingHandler : IRequestHandler<DeleteBooking>
{
    private readonly IApplicationDbContext _context;
    private readonly ICurrentUserService _currentUserService;
    private readonly IIdentityService _identityService;

    public DeleteBookingHandler(IApplicationDbContext context,ICurrentUserService currentUserService,
        IIdentityService identityService)
    {
        _context = context;
        _currentUserService = currentUserService;
        _identityService = identityService;
    }

    public async Task<Unit> Handle(DeleteBooking request, CancellationToken cancellationToken)
    {
        var isAdmin = await _identityService.IsInRoleAsync(_currentUserService.UserId, "Administrator");

        if (!isAdmin)
        {
            throw new Exception("You dont have permission to delete");
        }
        var entity = await _context.Bookings
            .FirstOrDefaultAsync(x=>x.Id == request.Id,cancellationToken);

        if (entity == null)
        {
            throw new NotFoundException(nameof(Bookings), request.Id);
        }

        _context.Bookings.Remove(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}