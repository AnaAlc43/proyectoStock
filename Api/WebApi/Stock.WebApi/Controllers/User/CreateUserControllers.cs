using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stock.BusinessRules.Interfaces.Controllers.UserControllers;
using System.Threading.Tasks;

namespace Stock.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IGetUserByIdController _getUserController;

        public UserController(IGetUserByIdController getUserController)
        {
            _getUserController = getUserController;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _getUserController.GetUser(id);

            if (user == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            else if (user.ErrorNumber != 0 && !string.IsNullOrEmpty(user.Message))
            {
                return BadRequest(user);
            }
            else
            {
                return Ok(user);
            }
        }
    }
}
