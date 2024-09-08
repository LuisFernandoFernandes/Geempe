using AutoMapper;
using Geempe.Application.DTOs;
using Geempe.Application.Interfaces;
using Geempe.Domain.Entities;
using Geempe.Infra.Interfaces;

namespace Geempe.Application.Services;

public class LoanRequestService(ILoanRequestRepository _repository, IMapper _mapper) : ServiceBase<LoanRequest, LoanRequestDTO>(_repository, _mapper), ILoanRequestService
{
}
