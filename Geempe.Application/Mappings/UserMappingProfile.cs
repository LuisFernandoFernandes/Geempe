using AutoMapper;
using Geempe.Application.DTOs;
using Geempe.Domain.Entities;

namespace Geempe.Application.Mappings;

public class UserMappingProfile : Profile
{
    public UserMappingProfile()
    {
        CreateMap<User, UserDTO>().ReverseMap();
    }
}
