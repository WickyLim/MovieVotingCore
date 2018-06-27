# Movie Voting App
This project is build with `ASP.NET Core` framework, conecting to a `local SQLite` database. To setup a simple web app with `ASP.NET Core` framework, you can refer to [this tutorial](https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages-mac/?view=aspnetcore-2.1) on microsoft.com


## Setup project on Docker
1. Create Web App project
2. Right click project on Solution Explorer > Add > Add Docker Support
3. Change `Dockerfile` to (replace `ProjectName` to your own project name)
```shell
FROM microsoft/aspnetcore-build:2.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore ProjectName.csproj

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out ProjectName.csproj

# Build runtime image
FROM microsoft/aspnetcore:2.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "ProjectName.dll"]
```
4. On command prompt, navigate to project's directory
5. On command prompt, run `docker build -t image-name .` (replace `image-name` to your own preferred name)
6. On command prompt, run `docker run -d -p 8080:80 --name container-name image-name` (replace `container-name` and `image-name` to your own preferred name)
7. Visit http://localhost:8080


## References
1. Simple ASP.NET Core tutorial - https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages-mac/?view=aspnetcore-2.1
2. Dockerize a .NET Core application - https://docs.docker.com/engine/examples/dotnetcore/