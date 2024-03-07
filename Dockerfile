FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base

WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src
COPY ["Udea.Api/Udea.Api.csproj", "Udea.Api/"]
COPY ["Udea.Infrastructure/Udea.Infrastructure.csproj", "Udea.Infrastructure/"]
COPY ["Udea.Service/Udea.Service.csproj", "Udea.Service/"]
COPY ["Udea.Persistence/Udea.Persistence.csproj", "Udea.Persistence/"]
COPY ["Udea.Domain/Udea.Domain.csproj", "Udea.Domain/"]
RUN dotnet restore "Udea.Api/Udea.Api.csproj"
COPY . .
WORKDIR "/src/Udea.Api"
RUN dotnet build "Udea.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Udea.Api.csproj" -c Release -o /app/publish

FROM base AS final

ENV TZ="Europe/Istanbul"

WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Udea.Api.dll"]
