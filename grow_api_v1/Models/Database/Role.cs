using System;
using grow_api_v1.Models.Enums;

namespace grow_api_v1.Models;

public class Role : BaseModel<Guid>
{
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}