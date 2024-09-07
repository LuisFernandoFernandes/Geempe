using AutoMapper;
using Geempe.Application.DTOs;
using Geempe.Domain.Entities;

namespace Geempe.Application.Mappings;

public class LoanMappingProfile : Profile
{
    public LoanMappingProfile()
    {
        CreateMap<Loan, LoanDTO>()
            .ForMember(dest => dest.LenderId, opt => opt.MapFrom(src => src.LenderId))
            .ForMember(dest => dest.BorrowerId, opt => opt.MapFrom(src => src.BorrowerId))
            .ForMember(dest => dest.DueDate, opt => opt.MapFrom(src => src.DueDate));
    }
}
