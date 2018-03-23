FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

ENTRYPOINT ["dotnet", "ef",  "database", "update"]

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY core_api_test.sln ./
COPY core_api_test/core_api_test.csproj core_api_test/
RUN dotnet restore -nowarn:msb3202,nu1503
COPY . .
WORKDIR /src/core_api_test
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app


FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "core_api_test.dll"]
