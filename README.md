# API designer

VSCode .NET Core Web API template for generating swagger API

## ![](doc/img/icon_toolbox.png) Installation prerequisites

In order to run this project, the following tools must be preinstalled in the target environment:<br/>

| Tool      | Version | Source                                                  | Documentation                                                    |
|-----------|---------|---------------------------------------------------------|------------------------------------------------------------------|
| .NET Core | 6.0+    | [download](https://dotnet.microsoft.com/en-us/download) | [doc](https://docs.microsoft.com/en-us/dotnet/core/introduction) |
| VSCode    | 1.6+    | [download](https://code.visualstudio.com/download)      | [doc](https://docs.docker.com/get-started/)                      |

Recommended plugins for VSCode studio:

| Plugin                    | Source                                                                                                 |
|---------------------------|--------------------------------------------------------------------------------------------------------|
| C#                        | [download](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)                  |
| Visual Studio IntelliCode | [download](https://marketplace.visualstudio.com/items?itemName=VisualStudioExptTeam.vscodeintellicode) |

## ![](doc/img/icon_manual.png) How to generate Swagger API

via command line (powershell/cmd/bash):
```powershell
# navigate to this project directory
cd C:\Users\jfuksa\source\repos\apidesigner\
# run following command
dotnet run
```

### OR

via VSCode GUI
```powershell
# In window menu select 
File -> Open folder
Button 'Run and debug'
```

Swagger API is now available on localhost at the url:
> https://localhost:8080/swagger/index.html

Thats it!

<br/>
<br/>
<br/>

## ![](doc/img/icon_automation.png) Customization
### Swagger port
```powershell
# change the default port on localhost in 'launchSettings.json' file
"applicationUrl": "https://localhost:8080;http://localhost:8081"
```

## ![](doc/img/icon_links.png) Links

https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-6.0&tabs=visual-studio-code#xml-comments  
https://dev.to/pdelcogliano/improve-your-web-api-with-swagger-documentation-1j83  
https://code-maze.com/swagger-ui-asp-net-core-web-api/
