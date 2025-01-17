using Microsoft.AspNetCore.Mvc;
using Business.Interfaces;
using Common.Models.WebAPI;
using Common.Interfaces;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CreateUserController : ControllerBase
    {

        private readonly ICreateUserService _createUserService;
        private readonly ICreateUserMapper _createUserMapper;
        public CreateUserController(ICreateUserService createUserService, ICreateUserMapper createUserMapper)
        {
            _createUserService = createUserService;
            _createUserMapper = createUserMapper;
        }


        [HttpPost]
        public Task<string> CreateUserAsync([FromBody] CreateUserDto user)
        {
  
            var userBusiness = _createUserMapper.ToBusinessModel(user);

            return _createUserService.CreateUser(userBusiness);
        }  

    }
}
