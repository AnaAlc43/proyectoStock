using Microsoft.AspNetCore.Mvc;
using Umbraco.Core.Services;


namespace Stock.WebApi.Controllers.User
{
    [ApiController]
    [Route("[controller]")]
    public class CreateUserControllers : ControllerBase
    {
      
        private readonly IUserService _userService;

        public CreateUserControllers(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CreateUserControllers>>> GetAllUser()
        {
            var users = await _userService.GetAllUserAsync();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IUserService>> GetUser(int id)
        {
            var user = await _userService.GetUserAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<CreateUserControllers>> CreateUser(User user)
        {
            await _userService.CreateUserAsync(user);
            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _userService.GetUserAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            await _userService.DeleteUserAsync(id);
            return NoContent();
        }
    }
    


    {
        [ApiController]
        [Route("api/users")]
        public class UserController : ControllerBase
        {
            private readonly UserService _userService;

            public UserController(UserService userService)
            {
                _userService = userService;
            }

            [HttpPost]
            public ActionResult CreateUser([FromBody] UserDto userDto)
            {
                try
                {
                    var newUser = _userService.CreateUser(userDto.Username, userDto.Password, userDto.Roles);
                    return CreatedAtAction(nameof(GetUser), new { id = newUser.Id }, newUser);
                }
                catch (Exception ex)
                {
                    return BadRequest(new { error = ex.Message });
                }
            }

            [HttpGet("{id}")]
            public ActionResult<UserDto> GetUser(int id)
            {
                var user = _userService.GetUserById(id);
                if (user != null)
                {
                    return Ok(user);
                }

                return NotFound(new { error = "User not found" });
            }
        }

      
    }

}

