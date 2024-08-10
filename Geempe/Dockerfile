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
COPY Geempe.Test/Geempe.Test.csproj Geempe.Test/
RUN dotnet restore

# Copie o restante dos arquivos e compile a aplicação
COPY . .
WORKDIR /src
RUN dotnet publish Geempe.sln -c Release -o /app/publish

# Use a imagem base do .NET Runtime para rodar a aplicação
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 80
ENTRYPOINT ["dotnet", "Geempe.Api.dll"]
