FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
#COPY Ashpazbashi.BackofficeUI.Web.csproj .
#RUN dotnet restore "Ashpazbashi.BackofficeUI.Web.csproj"
COPY . .
RUN dotnet build "./02. Endpoint/Ashpazbashi.BackofficeUI.Web/Ashpazbashi.BackofficeUI.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "./02. Endpoint/Ashpazbashi.BackofficeUI.Web/Ashpazbashi.BackofficeUI.Web.csproj" -c Release -o /app/publish

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=publish /app/publish/wwwroot/ .
COPY nginx.conf /etc/nginx/nginx.conf