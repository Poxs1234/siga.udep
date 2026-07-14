# Etapa de compilación
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Copiar todo el proyecto
COPY . .

# Restaurar dependencias
RUN dotnet restore

# Publicar la aplicación
RUN dotnet publish -c Release -o /app/publish

# Etapa de ejecución
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app

COPY --from=build /app/publish .

# Puerto utilizado por Render
ENV ASPNETCORE_URLS=http://+:10000
EXPOSE 10000

# Cambia Udep.dll por el nombre de tu proyecto si es diferente
ENTRYPOINT ["dotnet", "Udep.dll"]