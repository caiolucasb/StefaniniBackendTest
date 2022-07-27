FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /
COPY ["ST.App/ST.App.csproj", "ST.App/"]
COPY ["ST.CrossCutting/ST.CrossCutting.csproj", "ST.CrossCutting/"]
COPY ["ST.IoC/ST.IoC.csproj", "ST.IoC/"]
COPY ["ST.Repository/ST.Repository.csproj", "ST.Repository/"]
COPY ["ST.Service/ST.Service.csproj", "ST.Service/"]
RUN dotnet restore "ST.App/ST.App.csproj"
COPY . .
WORKDIR "/ST.App"
RUN dotnet build "ST.App.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ST.App.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ST.App.dll"]