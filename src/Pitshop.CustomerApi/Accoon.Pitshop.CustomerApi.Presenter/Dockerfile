FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["src/Pitshop.CustomerApi/Accoon.Pitshop.CustomerApi.Presenter/Accoon.Pitshop.CustomerApi.Presenter.csproj", "src/Pitshop.CustomerApi/Accoon.Pitshop.CustomerApi.Presenter/"]
COPY ["src/Pitshop.CustomerApi/Accoon.Pitshop.CustomerApi.Persistence/Accoon.Pitshop.CustomerApi.Persistence.csproj", "src/Pitshop.CustomerApi/Accoon.Pitshop.CustomerApi.Persistence/"]
COPY ["src/Pitshop.CustomerApi/Accoon.Pitshop.CustomerApi.Application/Accoon.Pitshop.CustomerApi.Application.csproj", "src/Pitshop.CustomerApi/Accoon.Pitshop.CustomerApi.Application/"]
COPY ["src/Pitshop.CustomerApi/Accoon.Pitshop.CustomerApi.Domain/Accoon.Pitshop.CustomerApi.Domain.csproj", "src/Pitshop.CustomerApi/Accoon.Pitshop.CustomerApi.Domain/"]
RUN dotnet restore "src/Pitshop.CustomerApi/Accoon.Pitshop.CustomerApi.Presenter/Accoon.Pitshop.CustomerApi.Presenter.csproj"
COPY . .
WORKDIR "/src/src/Pitshop.CustomerApi/Accoon.Pitshop.CustomerApi.Presenter"
RUN dotnet build "Accoon.Pitshop.CustomerApi.Presenter.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Accoon.Pitshop.CustomerApi.Presenter.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Accoon.Pitshop.CustomerApi.Presenter.dll"]