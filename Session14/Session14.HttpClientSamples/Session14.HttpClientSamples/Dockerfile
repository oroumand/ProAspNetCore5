#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Session14.HttpClientSamples/Session14.HttpClientSamples.csproj", "Session14.HttpClientSamples/"]
RUN dotnet restore "Session14.HttpClientSamples/Session14.HttpClientSamples.csproj"
COPY . .
WORKDIR "/src/Session14.HttpClientSamples"
RUN dotnet build "Session14.HttpClientSamples.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Session14.HttpClientSamples.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Session14.HttpClientSamples.dll"]