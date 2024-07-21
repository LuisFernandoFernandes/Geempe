using AutoMapper;
using Geempe.Application.DTOs;
using Geempe.Application.Mappings;
using Geempe.Application.Result;
using Geempe.Application.Services;
using Geempe.Domain.Entities;
using Geempe.Infra.Interfaces;
using Moq;

namespace Geempe.Test.Application;

public class UserServiceTest
{
    [Fact]
    public async Task UserService_GetAll_ShouldSucceed()
    {
        // Arrange
        var repository = new Mock<IUserRepository>();
        var mapper = new MapperConfiguration(x =>
        {
            x.AddProfile(new UserMappingProfile());
        });
        var _mapper = mapper.CreateMapper();
        var service = new UserService(repository.Object, _mapper);


        repository.Setup(repo => repo.GetAll()).ReturnsAsync(new List<User>
        {
            new User(1, "lf", "a@a", "iaushasiuhs"),
            new User(2, "lf2", "a@a2", "2iaushasiuhs"),
            new User(1, "lf3", "a@a3", "3iaushasiuhs")
        });


        // Act
        var result = await service.GetAll();

        // Assert
        var okResult = Assert.IsType<ServiceResult<ICollection<UserDTO>>>(result);
        Assert.True(okResult.IsSuccess);
    }
}
