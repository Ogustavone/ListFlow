namespace ListFlow.Models;

public class BaseEntity : IAuditable
{
    /// <summary>
    /// Unique identifier for the entity.
    /// </summary>
    public Guid Id { get; init; } = new Guid();

    /// <summary>
    /// Datetime (UTC) when the entity was created.
    /// IAutitable implementation.
    /// </summary>
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;

    /// <summary>
    /// Last updated datetime of the entity (UTC).
    /// IAuditable implementation. Can be null.
    /// </summary>
    public DateTime? UpdatedAt { get; set; } = null;

    public void UpdateEntity()
    {
        UpdatedAt = DateTime.UtcNow;
    }
}
