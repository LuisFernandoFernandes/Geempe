# Use a imagem base do .NET SDK para compilar e publicar a aplicação
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copie o arquivo de solução e os arquivos de projeto
COPY Geempe.sln .
COPY Geempe/Geempe.Api.csproj Geempe/
COPY Geempe.Application/Geempe.Application.csproj Geempe.Application/
COPY Geempe.Domain/Geempe.Domain.csproj Geempe.Domain/
COPY Geempe.Infra/Geempe.Infra.csproj Geempe.Infra/
COPY Geempe.IoC/Geempe.IoC.csproj Geempe.IoC/
RUN dotnet restore Geempe/Geempe.Api.csproj

# Copie o restante dos arquivos e compile a aplicação
COPY . .
WORKDIR /src/Geempe
RUN dotnet publish Geempe.Api.csproj -c Release -o /app/publish

# Use a imagem base do .NET Runtime para rodar a aplicação
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

# Defina a variável de ambiente para permitir o Swagger
ENV ASPNETCORE_ENVIRONMENT=Development
ENV ASPNETCORE_PORT=80

EXPOSE 80
ENTRYPOINT ["dotnet", "Geempe.Api.dll"]
