using Geempe.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Geempe.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController(IUserService service) : ControllerBase
{
}
