using System;

namespace grow_api_v1.DTOs.Responses;

public class ProduceVM
{
    public Guid Id { get; set; }
    public string Season { get; set; }
    public string Category { get; set; }
    
}