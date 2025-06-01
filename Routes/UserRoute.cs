namespace ListFlow.Routes;

public static class UserRoute
{
    public static void UserRoutes(this WebApplication app)
    {
        app.MapGet("/users", () => "rota /users");
    }
}
