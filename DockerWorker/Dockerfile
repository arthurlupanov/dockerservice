#FROM microsoft/windowsservercore:1709
FROM microsoft/windowsservercore
WORKDIR /app
COPY ./bin/Debug .
ENTRYPOINT DockerWorker.exe