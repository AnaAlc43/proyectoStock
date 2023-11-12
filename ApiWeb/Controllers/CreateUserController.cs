using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stock.BusinessRules.DTOs.UserDTOs;
using Stock.BusinessRules.Interfaces.Controllers.UserControllers;
using Stock.COMMON.Interfaces.Repositories;
using Stock.Controllers.UserControllers;
using Stock.Repository.Repositories;

namespace ApiWeb.Controllers
{
    [Route("api/users")]
    [ApiController]

    /*
    public class CreateUserController : ControllerBase
    {
        private readonly ICreateUserController _createUserController;

        public CreateUserController(ICreateUserController createUserController)
        {
            _createUserController = createUserController;
        }

        [HttpPost("Create")]
        public async Task<ActionResult> CreateUser([FromBody] CreateUserRequest request)
        {
            if (request == null) return BadRequest("");
            await _createUserController.CreateUser(request);
            return Ok();
        }

    } */


        public class Startup
        {
            public void ConfigureServices(IServiceCollection services)
            {
                services.AddScoped<IUserRepository, UserRepository>();
                services.AddScoped<ICreateUserController, CreateUserController>();
            }

            public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            {
                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                }

                app.UseRouting();

                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapPost("/create", async (CreateUserRequest request, ICreateUserController controller) =>
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
                });
            }
        }
    
}  


