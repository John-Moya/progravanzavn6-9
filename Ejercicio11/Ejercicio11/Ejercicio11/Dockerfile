#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Ejercicio11/Ejercicio11.csproj", "Ejercicio11/"]
RUN dotnet restore "Ejercicio11/Ejercicio11.csproj"
COPY . .
WORKDIR "/src/Ejercicio11"
RUN dotnet build "Ejercicio11.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Ejercicio11.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ejercicio11.dll"]