#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["POC.Docker.Scale/POC.Docker.Scale.csproj", "POC.Docker.Scale/"]
RUN dotnet restore "POC.Docker.Scale/POC.Docker.Scale.csproj"
COPY . .
WORKDIR "/src/POC.Docker.Scale"
RUN dotnet build "POC.Docker.Scale.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "POC.Docker.Scale.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "POC.Docker.Scale.dll"]