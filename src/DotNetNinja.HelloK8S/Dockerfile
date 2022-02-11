#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DotNetNinja.HelloK8S.csproj", "src/DotNetNinja.HelloK8S/"]
RUN dotnet restore "src/DotNetNinja.HelloK8S/DotNetNinja.HelloK8S.csproj"
COPY . "src/DotNetNinja.HelloK8S/"
WORKDIR "/src/src/DotNetNinja.HelloK8S"
RUN dotnet build "DotNetNinja.HelloK8S.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DotNetNinja.HelloK8S.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DotNetNinja.HelloK8S.dll"]