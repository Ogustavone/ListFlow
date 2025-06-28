using System.ComponentModel.DataAnnotations;
namespace ListFlow.Models;

public class TaskRequest
{
    [Required(ErrorMessage = "Title is required.")]
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;
    public List<string>? Tags { get; set; } = [];
    public StatusType? Status { get; set; } = StatusType.Backlog;
}

public class TaskPatchRequest
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public List<string>? Tags { get; set; }
    public StatusType? Status { get; set; }
}

public class TaskPutRequest
{
    [Required(ErrorMessage = "Title is required.")]
    public string Title { get; set; } = string.Empty;
    [Required(ErrorMessage = "Description is required.")]
    public string Description { get; set; } = string.Empty;
}