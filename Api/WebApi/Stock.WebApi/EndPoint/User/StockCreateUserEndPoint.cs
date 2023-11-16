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


    /*[ApiController]
    [Route("[controller]")]

    public class UserController : ControllerBase
    {
        // Implementación de la acción de registro del usuario
        [HttpPost("create")]
        public IActionResult CreateUser([FromBody] CreateUserRequest userRequest)
        {
            // La lógica de validación y registro del usuario

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            //_context.Users.Add(user);
            //_context.SaveChanges();

            // Si el registro del usuario es exitoso, devolver una respuesta HTTP 200 (OK)
            // con la información del usuario creado
            return Ok(userRequest);
        }
    }*/
    
}