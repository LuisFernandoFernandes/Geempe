using AutoMapper;
using Geempe.Application.DTOs;
using Geempe.Domain.Entities;

namespace Geempe.Application.Mappings
{
    public class LoanRequestMappingProfile : Profile
    {
        public LoanRequestMappingProfile()
        {
            CreateMap<LoanRequest, LoanRequestDTO>().ReverseMap();
        }
    }
}
