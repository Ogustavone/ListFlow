namespace ListFlow.Routes;

public static class UserRoute
{
    public static void UserRoutes(this WebApplication app)
    {
        var route = app.MapGroup("users");

        // GET /users
        // GET /users/id
        // POST /users
        // DELETE /users/id
        // PUT /users/id
    }
}
