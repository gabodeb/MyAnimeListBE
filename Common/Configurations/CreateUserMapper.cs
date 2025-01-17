using AutoMapper;
using Common.Interfaces;
using Common.Models.Business;
using Common.Models.WebAPI;

namespace Common.Configurations
{
    public class CreateUserMapper : ICreateUserMapper
    {
        private readonly IMapper _mapper;

        public CreateUserMapper(IMapper mapper)
        {
            _mapper = mapper;
        }
        public CreateUser ToBusinessModel(CreateUserDto dto)
        {
            return _mapper.Map<CreateUser>(dto);
        }

        public CreateUserDto ToDtoModel(CreateUser model)
        {
            return _mapper.Map<CreateUserDto>(model);
        }
    }
}
