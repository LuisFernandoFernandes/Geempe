using FluentValidation.AspNetCore;
using Geempe.Infra.Context;
using Microsoft.Extensions.DependencyInjection;

namespace Geempe.IoC;
public static class DependecyInjection
{
    public static IServiceCollection AddDependencies(this IServiceCollection services)
    {
        services.AddFluentValidationAutoValidation();
        services.AddDbContext<AppDBContext>(ServiceLifetime.Scoped);


        //services.AddAutoMapper(typeof(DDDMapingProfile));
        //services.AddScoped<IDDDRepository, DDDRepository>();
        //services.AddScoped<IDDDService, DDDService>();
        //services.AddScoped<IValidator<DDDDto>, DDDValidator>();
        //services.AddScoped<IValidator<ContatoDTO>, ContatoValidator>();


        //services.AddScoped<IContatoRepository, ContatoRepository>();
        //services.AddScoped<IContatoService, ContatoService>();
        //services.AddAutoMapper(typeof(ContatoMapingProfile));


        return services;
    }
}
