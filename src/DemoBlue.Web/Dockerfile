FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["src/DemoBlue.Web/DemoBlue.Web.csproj", "src/DemoBlue.Web/"]
RUN dotnet restore "src/DemoBlue.Web/DemoBlue.Web.csproj"
COPY . .
WORKDIR "/src/src/DemoBlue.Web"
RUN dotnet build "DemoBlue.Web.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "DemoBlue.Web.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DemoBlue.Web.dll"]
