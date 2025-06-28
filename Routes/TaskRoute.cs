using ListFlow.Data;
using ListFlow.Models;
using Microsoft.EntityFrameworkCore;

namespace ListFlow.Routes;

public static class TaskRoute
{
    public static void TaskRoutes(this WebApplication app)
    {
        var route = app.MapGroup("tasks");

        // GET /tasks
        route.MapGet("", async (AppDbContext context) =>
        {
            var tasks = await context.Tasks.ToListAsync();
            return tasks != null ? Results.Ok(tasks) : Results.NoContent();
        });

        // GET /tasks/{id}
        route.MapGet("{id:guid}", async (Guid id, AppDbContext context) =>
        {
            var task = await context.Tasks.FindAsync(id);
            return task != null ? Results.Ok(task) : Results.NotFound();
        });

        // POST /tasks
        route.MapPost("", async (TaskRequest req, AppDbContext context) =>
        {
            var newTask = new TaskModel
            {
                Title = req.Title,
                Description = req.Description ?? string.Empty,
                Tags = req.Tags ?? []
            };

            await context.AddAsync(newTask);
            await context.SaveChangesAsync();
            return Results.Created($"/tasks/{newTask.Id}", newTask);
        });

        // DELETE /tasks/{id}
        route.MapDelete("{id:guid}", async (Guid id, AppDbContext context) =>
        {
            var task = await context.Tasks.FindAsync(id);
            if (task == null)
            {
                return Results.NotFound();
            }

            context.Tasks.Remove(task);
            await context.SaveChangesAsync();
            return Results.Ok($"Task {task.Title} is deleted.");
        });

        // PATCH /tasks/{id}
        route.MapPatch("{id:guid}", async (Guid id, TaskPatchRequest req, AppDbContext context) =>
        {
            if (req == null)
            {
                return Results.BadRequest("Patch request body is required.");
            }

            var task = await context.Tasks.FindAsync(id);
            if (task == null)
            {
                return Results.NotFound();
            }

            task.Title = req.Title ?? task.Title;
            task.Description = req.Description ?? task.Description;
            task.Tags = req.Tags ?? task.Tags;

            if (req.Status != null)
            {
                if (!Enum.IsDefined(typeof(StatusType), req.Status.Value))
                {
                    return Results.BadRequest("Invalid status value.");
                }
                task.Status = req.Status.Value;
            }

            await context.SaveChangesAsync();
            return Results.Ok(task);
        });

        // PUT /tasks/{id}
        route.MapPut("{id:guid}", async (Guid id, TaskPutRequest req, AppDbContext context) =>
        {
            var task = await context.Tasks.FindAsync(id);
            if (task == null)
            {
                return Results.NotFound();
            }

            task.Title = req.Title;
            task.Description = req.Description;

            await context.SaveChangesAsync();
            return Results.Ok(task);
        });
    }
}
