FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base

WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src
COPY ["eShop.Api/eShop.Api.csproj", "eShop.Api/"]
COPY ["eShop.Infrastructure/eShop.Infrastructure.csproj", "eShop.Infrastructure/"]
COPY ["eShop.Service/eShop.Service.csproj", "eShop.Service/"]
COPY ["eShop.Persistence/eShop.Persistence.csproj", "eShop.Persistence/"]
COPY ["eShop.Domain/eShop.Domain.csproj", "eShop.Domain/"]
RUN dotnet restore "eShop.Api/eShop.Api.csproj"
COPY . .
WORKDIR "/src/eShop.Api"
RUN dotnet build "eShop.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "eShop.Api.csproj" -c Release -o /app/publish

FROM base AS final

ENV TZ="Europe/Istanbul"

WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "eShop.Api.dll"]
