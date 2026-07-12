

FROM mcr.microsoft.com/dotnet/sdk:8.0 as reza-builder

WORKDIR /docker-src

COPY . .

RUN dotnet restore

RUN dotnet publish -c Release -o /publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS reza-runtime

WORKDIR /docker-app

COPY --from=reza-builder /publish .

EXPOSE 8080 

ENTRYPOINT ["dotnet","SaharBeautyWeb.dll"]