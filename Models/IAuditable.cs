namespace ListFlow.Models;

public interface IAuditable
{
    /// <summary>
    /// Datetime(UTC) when the entity was created.
    /// </summary>
    DateTime CreatedAt { get; init; }
    /// <summary>
    /// Last updated datetime of the entity (UTC).
    /// Can be null.
    /// </summary>
    DateTime? UpdatedAt { get; set; }
}
