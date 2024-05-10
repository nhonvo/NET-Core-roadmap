FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5147

ENV ASPNETCORE_URLS=http://+:5147

USER app
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG configuration=Release
WORKDIR /src
COPY ["2.Distributed Cache-redis.csproj", "./"]
RUN dotnet restore "2.Distributed Cache-redis.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "2.Distributed Cache-redis.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "2.Distributed Cache-redis.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "2.Distributed Cache-redis.dll"]
