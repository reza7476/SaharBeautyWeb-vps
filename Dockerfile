# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["SaharBeautyWeb/SaharBeautyWeb.csproj", "SaharBeautyWeb/"]
RUN dotnet restore "SaharBeautyWeb/SaharBeautyWeb.csproj"

COPY . .
WORKDIR "/src/SaharBeautyWeb"

RUN dotnet publish "SaharBeautyWeb.csproj" \
    -c Release \
    -o /app/publish \
    /p:UseAppHost=false

# Runtime Stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

COPY --from=build /app/publish .

ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

ENTRYPOINT ["dotnet", "SaharBeautyWeb.dll"]