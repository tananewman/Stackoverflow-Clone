FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS base

WORKDIR /app

RUN apt-get update && \
    apt-get install make && \
    apt-get clean

COPY . ./

EXPOSE 5000

ENTRYPOINT ["dotnet", "run", "--urls", "http://0.0.0.0:5000:5000", "--project", "Server/BlazorUiDemo.Server.csproj"]
