#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["discord_bot_garrisson/discord_bot_garrisson.csproj", "discord_bot_garrisson/"]
COPY ["Bot_common/Bot_common.csproj", "Bot_common/"]
RUN dotnet restore "discord_bot_garrisson/discord_bot_garrisson.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet build "discord_bot_garrisson.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "discord_bot_garrisson.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "discord_bot_garrisson.dll"]