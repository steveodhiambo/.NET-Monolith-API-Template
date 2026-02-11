namespace MonolithTemplate.Api.DTOs.Auth;

public sealed record RefreshTokenDto
{
    public required string RefreshToken { get; init; }
}
