# APP BLAZOR

## SETUP AND RUN

### INSTALL TEMPLATES BLAZOR

```sh
dotnet new -i Microsoft.AspNetCore.Blazor.Templates::3.0.0-preview7.19365.7
```

### CREATE PROJECT CLIENT-SIDE AND SERVER-SIDE

```sh
dotnet new blazorhosted -o [ProjectName]
```

### RUN PROJECT

```sh
dotnet run [--urls]
```

### WATCH RUN LIVE-RELOAD

```sh
dotnet watch run [--urls]
```

### DEPENDENCIES

| LIB                         | VERSION | LINK                                                                                     |
| --------------------------- | ------- | ---------------------------------------------------------------------------------------- |
| .NET Core 3.0 Preview 7 SDK | 3.0     | [DOWNLOAD](https://dotnet.microsoft.com/download/dotnet-core/3.0)                        |
| NHibernate                  | 5.1     | [DOWNLOAD](https://www.nuget.org/packages/NHibernate/)                                   |
| FluentNHibernate            | 2.1.2   | [DOWNLOAD](https://www.nuget.org/packages/FluentNHibernate/)                             |
| SQL Data Client             | 5.1     | [DOWNLOAD](https://www.nuget.org/packages/System.Data.SqlClient/4.8.0-preview2.19523.17) |

### INSTALL DEPENDENCIES

Open directory `GatecApp.Server` and execute the commands below:

```sh
dotnet add package NHibernate --version 5.2.6
dotnet add package FluentNHibernate --version 2.1.2
dotnet add package System.Data.SqlClient --version 4.8.0-preview2.19523.17
```

### DATABASE

Create the table `users` with fields than are in file `Users` in `GatecApp/Server/Models/Users`.  
Configure credentials in file `NHIbernateHelpers.cs` in `GatecApp/Server/Models/`.