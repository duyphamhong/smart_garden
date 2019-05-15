FROM microsoft/dotnet:3.0-aspnetcore-runtime-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:3.0-sdk-stretch AS build
WORKDIR /src
COPY Embedded.Api/Embedded.Api.csproj Embedded.Api/
RUN dotnet restore Embedded.Api/Embedded.Api.csproj
COPY . .
WORKDIR /src/Embedded.Api
RUN dotnet build Embedded.Api.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Embedded.Api.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Embedded.Api.dll"]
