using System;
using grow_api_v1.Constants.Enums;
using grow_api_v1.Models.Enums;

namespace grow_api_v1.Models.Database;

public class Produce : BaseModel<Guid>
{
    public Season Season { get; set; }
    public Category Category { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}