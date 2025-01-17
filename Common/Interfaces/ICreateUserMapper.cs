

using Common.Models.Business;
using Common.Models.WebAPI;

namespace Common.Interfaces
{
    public interface ICreateUserMapper
    {
        CreateUser ToBusinessModel(CreateUserDto dto);
        CreateUserDto ToDtoModel(CreateUser model);
    }
}
