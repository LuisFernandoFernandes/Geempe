using FluentValidation;
using FluentValidation.AspNetCore;
using Geempe.Application.DTOs;
using Geempe.Application.Interfaces;
using Geempe.Application.Mappings;
using Geempe.Application.Services;
using Geempe.Application.Validators;
using Geempe.Infra.Context;
using Geempe.Infra.Interfaces;
using Geempe.Infra.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Geempe.IoC;
public static class DependecyInjection
{
    public static IServiceCollection AddDependencies(this IServiceCollection services)
    {
        services.AddFluentValidationAutoValidation();

        services.AddDbContext<AppDBContext>(ServiceLifetime.Scoped);

        services.AddAutoMapper(typeof(LoanMappingProfile));
        services.AddAutoMapper(typeof(LoanRequestMappingProfile));
        services.AddAutoMapper(typeof(PaymentMappingProfile));
        services.AddAutoMapper(typeof(UserMappingProfile));

        services.AddScoped<ILoanRepository, LoanRepository>();
        services.AddScoped<ILoanRequestRepository, LoanRequestRepository>();
        services.AddScoped<IPaymentRepository, PaymentRepository>();
        services.AddScoped<IUserRepository, UserRepository>();

        services.AddScoped<ILoanService, LoanService>();
        services.AddScoped<ILoanRequestService, LoanRequestService>();
        services.AddScoped<IPaymentService, PaymentService>();
        services.AddScoped<IUserService, UserService>();

        services.AddScoped<IValidator<LoanDTO>, LoanValidator>();
        services.AddScoped<IValidator<LoanRequestDTO>, LoanRequestValidator>();
        services.AddScoped<IValidator<PaymentDTO>, PaymentValidator>();
        services.AddScoped<IValidator<UserDTO>, UserValidator>();

        return services;
    }
}
