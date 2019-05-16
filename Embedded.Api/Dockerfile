FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Embedded.Api/Embedded.Api.csproj", "Embedded.Api/"]
RUN dotnet restore "Embedded.Api/Embedded.Api.csproj"
COPY . .
WORKDIR "/src/Embedded.Api"
RUN dotnet build "Embedded.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Embedded.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Embedded.Api.dll"]