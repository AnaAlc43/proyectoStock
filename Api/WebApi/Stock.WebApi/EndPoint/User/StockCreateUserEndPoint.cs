using Stock.BusinessRules.DTOs.UserDTOs;
using Stock.BusinessRules.Interfaces.Controllers.UserControllers;

namespace Stock.WebApi.EndPoint.User
{
    public static class StockCreateUserEndPoint
    {
        public static WebApplication CreateUserEndPoint(this WebApplication app)
        {
            app.MapPost("/create", async (CreateUserRequest request, ICreateUserController controller) =>
            {
                var result = await controller.CreateUser(request);

                if (!string.IsNullOrEmpty(result.Message) || result.ValidationErrors != null)
                {
                    return Results.BadRequest(result);
                }
                else
                {
                    return Results.Ok(result);
                }

            });

            return app;
        }
    }
}
