#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["techiz.Api/techiz.Api.csproj", "techiz.Api/"]
COPY ["techiz.Infrastructure/techiz.Infrastructure.csproj", "techiz.Infrastructure/"]
COPY ["techiz.Service/techiz.Service.csproj", "techiz.Service/"]
COPY ["techiz.Persistence/techiz.Persistence.csproj", "techiz.Persistence/"]
COPY ["techiz.Domain/techiz.Domain.csproj", "techiz.Domain/"]
RUN dotnet restore "./techiz.Api/techiz.Api.csproj"
COPY . .
WORKDIR "/src/techiz.Api"
RUN dotnet build "./techiz.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./techiz.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "techiz.Api.dll"]