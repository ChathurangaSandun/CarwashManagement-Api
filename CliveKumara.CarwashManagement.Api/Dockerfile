#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["CliveKumara.CarwashManagement.Api/CliveKumara.CarwashManagement.Api.csproj", "CliveKumara.CarwashManagement.Api/"]
RUN dotnet restore "CliveKumara.CarwashManagement.Api/CliveKumara.CarwashManagement.Api.csproj"
COPY . .
WORKDIR "/src/CliveKumara.CarwashManagement.Api"
RUN dotnet build "CliveKumara.CarwashManagement.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CliveKumara.CarwashManagement.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CliveKumara.CarwashManagement.Api.dll"]