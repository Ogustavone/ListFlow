using ListFlow.Data;
using ListFlow.Models;
using Microsoft.EntityFrameworkCore;

namespace ListFlow.Routes;

public static class TaskRoute
{
    public static void TaskRoutes(this WebApplication app)
    {
        var route = app.MapGroup("tasks");

        // POST /tasks
        route.MapPost("", async (TaskRequest req, AppDbContext context) =>
        {
            if (req.Title is null)
            {
                return Results.BadRequest("You need to assign a title to the task.");
            }
            var newTask = new TaskModel
            {
                Title = req.Title,
                Description = req.Description ?? string.Empty,
                Tags = req.Tags ?? []
            };

            await context.AddAsync(newTask);
            await context.SaveChangesAsync();
            return Results.Ok(newTask);
        });

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

        // PUT /tasks/{id}
        route.MapPut("{id:guid}", async (Guid id, TaskRequest req, AppDbContext context) =>
        {
            var task = await context.Tasks.FindAsync(id);
            if (task == null)
            {
                return Results.NotFound();
            }

            task.Title = req.Title ?? task.Title;
            task.Description = req.Description ?? task.Description;
            task.Tags = req.Tags ?? task.Tags;

            context.Tasks.Update(task);
            await context.SaveChangesAsync();
            return Results.Ok(task);
        });

        // PATCH /tasks/{id}/status
        route.MapPatch("{id:guid}/status", async (Guid id, ETaskStatus status, AppDbContext context) =>
        {
            //FIXME: Tratar exceção quando passar status diferente do model.
            var task = await context.Tasks.FindAsync(id);
            if (task == null)
            {
                return Results.NotFound();
            }
            task.Status = status;
            context.Tasks.Update(task);
            await context.SaveChangesAsync();
            return Results.Ok(task);
        });

        // DELETE /tasks/{id}
        route.MapDelete("{id:guid}", async (Guid id, bool confirm, AppDbContext context) =>
        {
            var task = await context.Tasks.FindAsync(id);
            if (task == null)
            {
                return Results.NotFound();
            }
            else if (!confirm)
            {
                return Results.Unauthorized();
            }
            context.Tasks.Remove(task);
            await context.SaveChangesAsync();
            return Results.Ok($"Task {task.Title} is deleted.");
        });
    }
}
