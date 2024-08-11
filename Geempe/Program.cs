using Geempe.Api.Filters;
using Geempe.Infra.Context;
using Geempe.IoC;

var builder = WebApplication.CreateBuilder(args);

var port = Environment.GetEnvironmentVariable("ASPNETCORE_PORT") ?? "5000";
builder.WebHost.ConfigureKestrel(serverOptions =>
{
    serverOptions.ListenAnyIP(int.Parse(port)); // Escuta na porta definida pela variável de ambiente
});

builder.Services.AddControllers();

builder.Services.
    AddControllers(options => options.Filters
    .Add(typeof(ModelStateValidatorFilter)))
    .ConfigureApiBehaviorOptions(options => { options.SuppressModelStateInvalidFilter = true; });

builder.Services.AddDbContext<AppDBContext>();

builder.Services.AddDependencies();

builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();

    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        c.RoutePrefix = string.Empty;
    });
}

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();