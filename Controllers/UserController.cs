using System.Reflection;
using Microsoft.AspNetCore.Mvc;

namespace MyAnimeListBE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "/home")]
        public string Home()
        {
            return "Test";
        }
    }
}
