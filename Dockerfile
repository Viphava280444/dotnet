FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY source/SimpleApi.csproj .
RUN dotnet restore "SimpleApi.csproj"
COPY source/ .
RUN dotnet build "SimpleApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SimpleApi.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
EXPOSE 80
EXPOSE 443
ENTRYPOINT ["dotnet", "SimpleApi.dll"]