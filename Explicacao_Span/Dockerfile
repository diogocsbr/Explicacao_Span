FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Explicacao_Span/Explicacao_Span.csproj", "Explicacao_Span/"]
RUN dotnet restore "Explicacao_Span/Explicacao_Span.csproj"
COPY . .
WORKDIR "/src/Explicacao_Span"
RUN dotnet build "Explicacao_Span.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Explicacao_Span.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Explicacao_Span.dll"]
