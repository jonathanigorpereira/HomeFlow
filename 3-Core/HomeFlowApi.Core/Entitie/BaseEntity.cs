namespace HomeFlowApi.Core.Entitie;

public abstract class BaseEntity
{
    protected BaseEntity()
    {
        Id = Guid.NewGuid();
        IsActive = true;       
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = null;
    }
    
    public Guid Id { get; set; }
    public bool IsActive { get; init; }
    public DateTime CreatedAt { get; init; } 
    public DateTime? UpdatedAt { get; init; } 
} 