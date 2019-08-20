FROM mcr.microsoft.com/dotnet/core/runtime:2.2
#FROM microsoft/dotnet:2.2-aspnetcore-runtime
WORKDIR /app

COPY . ./

#CMD dotnet run "app/bin/Release/netcoreapp2.1/publish/DOU-Companies-Web-Api.dll"
ENTRYPOINT ["dotnet", "app/bin/Release/netcoreapp2.2/publish/DOU-Companies-Web-Api.dll"]