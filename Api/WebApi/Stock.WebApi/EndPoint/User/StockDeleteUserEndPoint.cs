using Stock.BusinessRules.Interfaces.Controllers.UserControllers;

namespace Stock.WebApi.EndPoint.User
{
    public static class StockDeleteUserEndPoint
    {
        public static WebApplication DeleteUserEndPoint(this WebApplication app)
        {
            app.MapPut("/user/delete/{id}", async (IDeleteUserController controller, int idUser) =>
            {
                var user = await controller.DeleteUser(idUser);
                if (user == null)
                {
                    return Results.StatusCode(StatusCodes.Status500InternalServerError);

                }
                else if (user.ErrorNumber != 0 && !string.IsNullOrEmpty(user.Message))
                {
                    return Results.BadRequest(user);
                }

                return Results.Ok(user);
            });
            return app;
        }
    }
}
