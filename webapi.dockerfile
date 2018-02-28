FROM microsoft/aspnetcore-build

LABEL maintainer="fawad@outlook.com"

COPY . /app
WORKDIR /app

RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]

EXPOSE 5000/tcp
ENV ASPNETCORE_URLS http://*:5000

RUN apt-get update && apt-get install -y dos2unix

RUN dos2unix ./entrypoint.sh && apt-get --purge remove -y dos2unix && rm -rf /var/lib/apt/lists/*

RUN chmod +x ./entrypoint.sh
CMD /bin/bash ./entrypoint.sh