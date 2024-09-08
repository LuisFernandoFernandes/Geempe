using AutoMapper;
using Geempe.Application.DTOs;
using Geempe.Application.Interfaces;
using Geempe.Domain.Entities;
using Geempe.Infra.Interfaces;

namespace Geempe.Application.Services;

public class PaymentService(IPaymentRepository _repository, IMapper _mapper) : ServiceBase<Payment, PaymentDTO>(_repository, _mapper), IPaymentService
{

}