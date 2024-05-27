namespace grow_api_v1.Models.Enums;

public abstract class BaseModel<TKey>
{
    public TKey Id { get; set; }
}