using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stock.BusinessRules.DTOs.UserDTOs;
using Stock.BusinessRules.Interfaces.Controllers.UserControllers;

namespace ApiWeb.Controllers
{
    [Route("api/users")]
    [ApiController]
    
    public class CreateUserController : ControllerBase
    {
        private readonly ICreateUserController _createUserController;

        public CreateUserController(ICreateUserController createUserController)
        {
            _createUserController = createUserController;
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] CreateUserRequest request)
        {
            if (request == null) return BadRequest("");
            await _createUserController.CreateUser(request);
            return Ok();
        }
    }
}
