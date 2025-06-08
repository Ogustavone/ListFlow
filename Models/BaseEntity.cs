namespace ListFlow.Models;

public class BaseEntity
{
    /// <summary>
    /// Unique identifier for the entity.
    /// </summary>
    public Guid Id { get; private set; } = Guid.NewGuid();

    /// <summary>
    /// Datetime (UTC) when the entity was created.
    /// IAutitable implementation.
    /// </summary>
    public DateTime CreatedAt { get; } = DateTime.UtcNow;

    /// <summary>
    /// Last updated datetime of the entity (UTC).
    /// IAuditable implementation. Can be null.
    /// </summary>
    public DateTime UpdatedAt { get; private set; }

    /// <summary>
    /// Updates property "UpdatedAt" to the current UTC datetime.
    /// </summary>
    public void UpdateDateTime()
    {
        UpdatedAt = DateTime.UtcNow;
    }
}
