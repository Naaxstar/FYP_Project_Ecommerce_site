using FYP.Application.Common.Interfaces;

namespace FYP.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
