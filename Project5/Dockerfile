FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

COPY src/Project5.Domain/Project5.Domain.csproj ./src/Project5.Domain/
COPY src/Project5.Application/Project5.Application.csproj ./src/Project5.Application/
COPY src/Project5.Infrastructure/Project5.Infrastructure.csproj ./src/Project5.Infrastructure/
COPY src/Project5.Api/Project5.Api.csproj ./src/Project5.Api/
RUN dotnet restore ./src/Project5.Api/Project5.Api.csproj

COPY . ./
RUN dotnet publish ./src/Project5.Api -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime
WORKDIR /app
EXPOSE 5432
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "Project5.Api.dll"]
