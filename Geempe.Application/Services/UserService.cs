using AutoMapper;
using Geempe.Application.DTOs;
using Geempe.Application.Interfaces;
using Geempe.Domain.Entities;
using Geempe.Infra.Interfaces;

namespace Geempe.Application.Services;

public class UserService(IUserRepository _repository, IMapper _mapper) : ServiceBase<User, UserDTO>(_repository, _mapper), IUserService
{
}
