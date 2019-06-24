FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
WORKDIR /app
COPY ./src/Pitshop.CustomerApi/Accoon.Pitshop.CustomerApi.Presenter/bin/docker .
RUN ls
ENV ASPNETCORE_URLS http://*:5000
ENV ASPNETCORE_ENVIRONMENT docker
EXPOSE 5000
ENTRYPOINT dotnet Accoon.Pitshop.CustomerApi.Presenter.dll