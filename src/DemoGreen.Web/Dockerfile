FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["src/DemoGreen.Web/DemoGreen.Web.csproj", "src/DemoGreen.Web/"]
RUN dotnet restore "src/DemoGreen.Web/DemoGreen.Web.csproj"
COPY . .
WORKDIR "/src/src/DemoGreen.Web"
RUN dotnet build "DemoGreen.Web.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "DemoGreen.Web.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DemoGreen.Web.dll"]
