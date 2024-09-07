using AutoMapper;
using Geempe.Application.DTOs;
using Geempe.Application.Interfaces;
using Geempe.Domain.Entities;
using Geempe.Infra.Interfaces;

namespace Geempe.Application.Services
{
    public class LoanService(ILoanRepository _repository, IMapper _mapper) : ServiceBase<Loan, LoanDTO>(_repository, _mapper), ILoanService
    {
    }
}
