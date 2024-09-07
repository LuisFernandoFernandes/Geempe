using Geempe.Application.DTOs;
using Geempe.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Geempe.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LoanController(ILoanService _service) : ControllerBase<LoanDTO>(_service)
{
}
