namespace ListFlow.Routes;

public static class TaskRoute
{
    public static void TaskRoutes(this WebApplication app)
    {
        app.MapGet("/tasks", () => "rota /tasks");
    }
}
