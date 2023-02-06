FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Sample.Gridify.WebApi/Sample.Gridify.WebApi.csproj", "src/Sample.Gridify.WebApi/"]
COPY ["src/Sample.Gridify.Core/Sample.Gridify.Core.csproj", "src/Sample.Gridify.Core/"]
RUN dotnet restore "src/Sample.Gridify.WebApi/Sample.Gridify.WebApi.csproj"
COPY . .
WORKDIR "/src/src/Sample.Gridify.WebApi"
RUN dotnet build "Sample.Gridify.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Sample.Gridify.WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Sample.Gridify.WebApi.dll"]