#FROM microsoft/aspnet:4.7.1-windowsservercore-1709
FROM microsoft/aspnet
#EXPOSE 4022 4023
#RUN Invoke-WebRequest -OutFile c:\vs_remotetools.exe -Uri https://download.microsoft.com/download/8/8/8/888988f5-43db-4882-ac1a-e7f79ee70712/vs_remotetools.exe;
#RUN & 'c:\vs_remotetools.exe' /install /quiet
COPY . /inetpub/wwwroot