using MonolithTemplate.Api.DTOs.Auth;
using MonolithTemplate.Api.Entities;

namespace MonolithTemplate.Api.DTOs.Users;

public static class UserMappings
{
    public static User ToEntity(this RegisterUserDto dto)
    {
        return new User
        {
            Id = $"u_{Guid.CreateVersion7()}",
            Name = dto.Name,
            Email = dto.Email,
            CreatedAtUtc = DateTime.UtcNow,
        };
    }
}
