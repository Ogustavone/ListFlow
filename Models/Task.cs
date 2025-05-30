namespace ListFlow.Models;

public class Task : BaseEntity
{
    public required string Title { get; set; }
    public string Description { get; set; } = string.Empty;
    public TaskStatus Status { get; set; } = TaskStatus.Backlog;
    public List<string> Tags { get; set; } = [];
}
