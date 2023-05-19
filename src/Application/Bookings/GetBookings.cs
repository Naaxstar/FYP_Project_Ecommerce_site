using AutoMapper;
using AutoMapper.QueryableExtensions;
using FYP.Application.Common.Interfaces;
using FYP.Application.Common.Mappings;
using FYP.Application.Common.Models;
using FYP.Application.TodoItems.Queries.GetTodoItemsWithPagination;
using FYP.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection.Bookings;

public class GetBookings: IRequest<List<Booking>>
{
}

public class GetTodoItemsWithPaginationQueryHandler :IRequestHandler<GetBookings, List<Booking>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;
    private readonly ICurrentUserService _currentUserService;
    private readonly IIdentityService _identityService;

    public GetTodoItemsWithPaginationQueryHandler(IApplicationDbContext context, IMapper mapper, 
        ICurrentUserService currentUserService,
        IIdentityService identityService)
    {
        _context = context;
        _mapper = mapper;
        _currentUserService = currentUserService;
        _identityService = identityService;
    }

    public async Task<List<Booking>> Handle(GetBookings request, CancellationToken cancellationToken)
    {
        var isAdmin = await _identityService.IsInRoleAsync(_currentUserService.UserId, "Administrator");
        return await _context.Bookings
            .ToListAsync();
    }
}
