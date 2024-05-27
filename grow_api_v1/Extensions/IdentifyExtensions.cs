using System;
using System.Linq;
using System.Security.Claims;
using grow_api_v1.Constants;
using grow_api_v1.Constants.Errors;
using grow_api_v1.Models;

namespace grow_api_v1.Extensions;

public static class IdentityExtensions
{
    public static Guid GetUserId(this ClaimsPrincipal claimsPrincipal)
    {
        var subject = claimsPrincipal?.Identity?.Name;

        return Guid.TryParse(subject, out var id)
            ? id
            : throw new UnauthorizedAccessException(RepositoryErrors.User_DoesNotExist);
    }

    public static bool IsAdmin(this User user)
    {
        return user.Roles.Select(ur => ur.Role.Name).Contains(UserRoleType.Admin);
    }

    public static bool IsSuperAdmin(this User user)
    {
        return user.Roles.Select(ur => ur.Role.Name).Contains(UserRoleType.SuperAdmin);
    }
}