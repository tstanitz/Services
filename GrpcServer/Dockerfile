FROM microsoft/aspnetcore:2.0.4
WORKDIR /app
COPY /bin/Release/netcoreapp2.0/publish/ .
EXPOSE 5002
ENTRYPOINT ["dotnet", "GrpcServer.dll"]