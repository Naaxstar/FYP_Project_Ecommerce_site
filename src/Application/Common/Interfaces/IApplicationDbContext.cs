using FYP.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FYP.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }
    
    DbSet<Booking> Bookings { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
