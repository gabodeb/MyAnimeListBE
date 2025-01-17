using AutoMapper;
using Common.Models.Business;
using Common.Models.WebAPI;
using Microsoft.Win32;

namespace Common.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateUserDto, CreateUser>();
        }
    }
}
