using Microsoft.AspNetCore.Mvc;
using SecureWebApp.Services;
using SecureWebApp.Models;
using Microsoft.Extensions.Options;

namespace JWTAuthentication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;
    
        

        public UsersController(IUserService userService)
        {
            _userService = userService;
           
        }

        [HttpPost("authenticate")]
        public IActionResult Validate(AuthenticateRequest model)
        {
            var response = _userService.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });
               return Ok(response);
        }

       [Authorize]
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }
   
    }
    }