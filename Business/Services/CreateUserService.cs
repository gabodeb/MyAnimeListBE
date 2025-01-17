using Business.Interfaces;
using Common.Models.Business;
using Repository.Interfaces;

namespace Business.Services
{
    public class CreateUserService : ICreateUserService
    {

        private readonly ICreateUserRepository _createUserRepository;

        public CreateUserService(ICreateUserRepository createUserRepository)
        {
            _createUserRepository = createUserRepository;
        }
        public Task<string> CreateUser(CreateUser user)
        {
            return _createUserRepository.CreateUserAsync(user);
        }
    }
}
