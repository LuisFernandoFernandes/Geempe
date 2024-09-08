using AutoMapper;
using Geempe.Application.DTOs;
using Geempe.Domain.Entities;

namespace Geempe.Application.Mappings;

public class PaymentMappingProfile : Profile
{
    public PaymentMappingProfile()
    {
        CreateMap<Payment, PaymentDTO>().ReverseMap();
    }
}
