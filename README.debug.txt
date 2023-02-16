Debugging with Visual Studio Code on Linux
- JavaScript is debugged in browser
- .NET code is debugged in VSCode

Steps:
- Clone the Umbraco repository
  git clone https://github.com/OOSIS-oy/Umbraco-CMS.git

- Disable minification of JS
  --- Umbraco-CMS/src/Umbraco.Web.UI/appsettings.Development.template.json	2023-02-15 15:00:00.000000000 +0200
  +++ Umbraco-CMS/src/Umbraco.Web.UI/appsettings.Development.template.json	2023-02-15 15:01:00.000000000 +0200
  @@ -39,7 +39,7 @@
           "Debug": true
         },
         "RuntimeMinification": {
  -        "useInMemoryCache": false,
  +        "useInMemoryCache": true,
           "cacheBuster": "Timestamp"
         }
       }

- Disable opening browser automatically
  TODO

- Install node packages
  cd Umbraco-CMS/src/Umbraco.Web.UI.Client/
  npm install

- Run node
  cd Umbraco-CMS/src/Umbraco.Web.UI.Client/
  gulp dev

- Run .NET
  cd Umbraco-CMS/
  dotnet watch --project src/Umbraco.Web.UI/Umbraco.Web.UI.csproj

- In VSCode, run debug by using ".NET Core Attach (Umbraco-CMS)"

- Select the process "Umbraco.Web.UI"
