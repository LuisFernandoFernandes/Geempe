using AutoMapper;
using Geempe.Application.DTOs;
using Geempe.Application.Mappings;
using Geempe.Application.Result;
using Geempe.Application.Services;
using Geempe.Domain.Entities;
using Geempe.Infra.Interfaces;
using Moq;

namespace Geempe.Test.Application;

public class LoanServiceTest
{
    private readonly IMapper _mapper;
    private readonly Mock<ILoanRepository> _loanRepositoryMock;
    private readonly LoanService _loanService;

    public LoanServiceTest()
    {
        _loanRepositoryMock = new Mock<ILoanRepository>();
        _mapper = ConfigureMapper();
        _loanService = new LoanService(_loanRepositoryMock.Object, _mapper);
    }

    private IMapper ConfigureMapper()
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new LoanMappingProfile());
        });
        return config.CreateMapper();
    }


    [Fact]
    public async Task LoanService_GetAll_ReturnsListOfLoanDTO()
    {
        // Arrange
        var loan = new Loan(1, 2, 1000, 0.1m, DateTime.Now.AddDays(30))
        {
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };

        var loanList = new List<Loan> { loan };

        _loanRepositoryMock.Setup(x => x.GetAll()).ReturnsAsync(loanList);

        // Act
        var result = await _loanService.GetAll();

        // Assert
        Assert.IsType<ServiceResult<ICollection<LoanDTO>>>(result);
        Assert.NotNull(result.Data);
        Assert.Single(result.Data);

        var loanDto = result.Data.First();
        Assert.Equal(loan.Id, loanDto.Id);
        Assert.Equal(loan.LenderId, loanDto.LenderId);
        Assert.Equal(loan.BorrowerId, loanDto.BorrowerId);
        Assert.Equal(loan.Amount, loanDto.Amount);
        Assert.Equal(loan.InterestRate, loanDto.InterestRate);
        Assert.Equal(loan.DueDate, loanDto.DueDate);
    }
}
