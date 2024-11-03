#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["eShop.Api/eShop.Api.csproj", "eShop.Api/"]
COPY ["eShop.Infrastructure/eShop.Infrastructure.csproj", "eShop.Infrastructure/"]
COPY ["eShop.Service/eShop.Service.csproj", "eShop.Service/"]
COPY ["eShop.Persistence/eShop.Persistence.csproj", "eShop.Persistence/"]
COPY ["eShop.Domain/eShop.Domain.csproj", "eShop.Domain/"]
RUN dotnet restore "./eShop.Api/eShop.Api.csproj"
COPY . .
WORKDIR "/src/eShop.Api"
RUN dotnet build "./eShop.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./eShop.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "eShop.Api.dll"]