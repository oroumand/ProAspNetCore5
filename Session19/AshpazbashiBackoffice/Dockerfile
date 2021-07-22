# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env

WORKDIR /app


# Copy everything and build

COPY . ./

RUN dotnet publish "./03. Endpoints/AshpazbashiBackoffice.Endpoints.API" -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:latest
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "AshpazbashiBackoffice.Endpoints.API.dll","--environment development"]