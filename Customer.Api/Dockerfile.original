FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-stretch AS build
WORKDIR /src
COPY ["../Customer.Api/Customer.Api.csproj", "../Customer.Api/"]
RUN dotnet restore "../Customer.Api/Customer.Api.csproj"
COPY . .
WORKDIR "/src/../Customer.Api"
RUN dotnet build "Customer.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Customer.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Customer.Api.dll"]