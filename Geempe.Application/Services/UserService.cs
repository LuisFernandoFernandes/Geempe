using AutoMapper;
using Geempe.Application.Interfaces;
using Geempe.Infra.Interfaces;

namespace Geempe.Application.Services;

public class UserService(IUserRepository _repository, IMapper _mapper) : IUserService
{
}
