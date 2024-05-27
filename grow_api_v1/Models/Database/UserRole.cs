using System;
using grow_api_v1.Models.Enums;

namespace grow_api_v1.Models;

public class UserRole : BaseModel<Guid>
{
    public User User { get; set; }
    public Role Role { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }

    public UserRole()
    {
    }

    public UserRole(User user, Role role)
    {
        User = user;
        Role = role;
    }
}