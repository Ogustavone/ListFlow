namespace ListFlow.Models;

public class TaskRequest
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public List<string>? Tags { get; set; }
}
