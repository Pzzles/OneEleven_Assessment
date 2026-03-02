FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["OneEleven_Assessment/OneEleven_Assessment.csproj", "OneEleven_Assessment/"]
RUN dotnet restore "OneEleven_Assessment/OneEleven_Assessment.csproj"
COPY . .
WORKDIR "/src/OneEleven_Assessment"
RUN dotnet publish "OneEleven_Assessment.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "OneEleven_Assessment.dll"]
