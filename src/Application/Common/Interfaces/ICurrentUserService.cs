namespace FYP.Application.Common.Interfaces;

public interface ICurrentUserService
{
    string? UserId { get; }
    string? UserRole { get; }
}
