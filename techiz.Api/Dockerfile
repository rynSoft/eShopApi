FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base

WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src
COPY ["techiz.Api/techiz.Api.csproj", "techiz.Api/"]
COPY ["techiz.Infrastructure/techiz.Infrastructure.csproj", "techiz.Infrastructure/"]
COPY ["techiz.Service/techiz.Service.csproj", "techiz.Service/"]
COPY ["techiz.Persistence/techiz.Persistence.csproj", "techiz.Persistence/"]
COPY ["techiz.Domain/techiz.Domain.csproj", "techiz.Domain/"]
RUN dotnet restore "techiz.Api/techiz.Api.csproj"
COPY . .
WORKDIR "/src/techiz.Api"
RUN dotnet build "techiz.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "techiz.Api.csproj" -c Release -o /app/publish

FROM base AS final

ENV TZ="Europe/Istanbul"

WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "techiz.Api.dll"]
