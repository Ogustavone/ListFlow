namespace ListFlow.Models;

public class TaskModel : BaseEntity
{
    public required string Title { get; set; }
    public string Description { get; set; } = string.Empty;
    public StatusType Status { get; set; } = StatusType.Backlog;
    public List<string> Tags { get; set; } = [];
}

public enum StatusType
{
    Backlog,
    Pending,
    InProgress,
    Completed,
    Cancelled
}