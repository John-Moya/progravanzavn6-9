#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Ejercicio10.1/Ejercicio10.1.csproj", "Ejercicio10.1/"]
RUN dotnet restore "Ejercicio10.1/Ejercicio10.1.csproj"
COPY . .
WORKDIR "/src/Ejercicio10.1"
RUN dotnet build "Ejercicio10.1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Ejercicio10.1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ejercicio10.1.dll"]