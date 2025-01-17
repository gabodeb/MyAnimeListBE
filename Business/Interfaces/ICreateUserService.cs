using Common.Models.Business;

namespace Business.Interfaces
{
    public interface ICreateUserService
    {
        public Task<string> CreateUser(CreateUser user);
    }
}
