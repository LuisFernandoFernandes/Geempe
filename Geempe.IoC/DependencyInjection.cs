﻿using FluentValidation;
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

        services.AddAutoMapper(typeof(UserMappingProfile));
        services.AddAutoMapper(typeof(LoanMappingProfile));

        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<ILoanRepository, LoanRepository>();

        services.AddScoped<IUserService, UserService>();
        services.AddScoped<ILoanService, LoanService>();

        services.AddScoped<IValidator<UserDTO>, UserValidator>();
        services.AddScoped<IValidator<LoanDTO>, LoanValidator>();

        return services;
    }
}
