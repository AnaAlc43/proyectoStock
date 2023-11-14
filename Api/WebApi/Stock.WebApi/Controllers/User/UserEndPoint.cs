using Stock.BusinessRules.Interfaces.Controllers.UserControllers;

namespace Stock.WebApi.Controllers.User
{
    public static class UserEndPoint
    {
        public static WebApplication GetUserEndPoint(this WebApplication app)
        {
            app.MapGet("/user/{id}", async (IGetUserByIdController controller, int id) =>
            {
                var user = await controller.GetUser(id);

                if (user == null)
                {
                    return Results.StatusCode(StatusCodes.Status500InternalServerError);

                }
                else if (user.ErrorNumber != 0 && !string.IsNullOrEmpty(user.Message))
                {
                    return Results.BadRequest(user);

                }
                {
                    return Results.Ok(user);
                }
            });

            return app;
        }
    }
}