using System.Security.Claims;

namespace MonolithTemplate.Api.Extensions;

public static class ClaimsPrincipalExtensions
{
    public static string? GetIdentity(this ClaimsPrincipal? principal)
    {
        string? identityId = principal?.FindFirstValue(ClaimTypes.NameIdentifier);

        return identityId;
    }
} 
