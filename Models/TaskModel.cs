namespace ListFlow.Models;

public class TaskModel : BaseEntity
{
    public required string Title { get; set; }
    public string Description { get; set; } = string.Empty;
    public ETaskStatus Status { get; set; } = ETaskStatus.Backlog;
    public List<string> Tags { get; set; } = [];
}
