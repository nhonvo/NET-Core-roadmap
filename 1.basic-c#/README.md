# Learn the basic of C#

## C#

(section 1 -> 7)

## .NET 

(section 8 -> 10)

## .NET CLI


 Here is an updated report about the .NET CLI with examples of how to use each command:

### **Basic Commands**

- **new**: Creates a new .NET project or file.
Example: **dotnet new console -n MyConsoleApp** creates a new console application named "MyConsoleApp".
- **restore**: Restores dependencies and project-specific tools specified in the project file.
Example: **dotnet restore** restores dependencies for the current project.
- **build**: Builds a project and all its dependencies.
Example: **dotnet build** builds the current project.
- **publish**: Packs the application and its dependencies into a single folder for deployment.
Example: **dotnet publish -c Release -o publish** publishes the current project in release mode to the "publish" folder.
- **run**: Runs source code or a compiled application.
Example: **dotnet run** runs the current project.
- **test**: Runs tests in a given project.
Example: **dotnet test** runs tests in the current project.
- **vstest**: Runs tests using the Visual Studio Test runner.
Example: **dotnet vstest MyTestProject.dll** runs tests from the specified DLL file using Visual Studio Test runner.
- **pack**: Packages a project into a NuGet package.
Example: **dotnet pack** creates a NuGet package of the current project.
- **migrate**: Migrates a project.json-based project to a csproj-based project.
Example: **dotnet migrate** migrates the current project to the newer format.
- **clean**: Cleans the project by removing intermediate files and binaries.
Example: **dotnet clean** removes build artifacts from the current project.
- **sln**: Provides commands to modify or work with a solution file.
Example: **dotnet sln add MyProject/MyProject.csproj** adds a project to the solution file.
- **help**: Displays help information for CLI commands.
Example: **dotnet --help** shows a list of available commands and their descriptions.
- **store**: Manages the runtime store for shared runtime assemblies.
Example: **dotnet store --manifest MyApp.runtimeconfig.json** optimizes assemblies for the runtime.
- **watch**: Watches for file changes in the specified project and rebuilds and runs the application if a change occurs.
Example: **dotnet watch run** watches the current project and runs it whenever there are file changes.
- **format**: Formats the source code according to coding standards.
Example: **dotnet format** automatically formats source code in the current project.

**Project Modification Commands**

- **add package**: Adds a NuGet package reference to the project.
Example: **dotnet add package Newtonsoft.Json** adds the Newtonsoft.Json package to the project.
- **add reference**: Adds a project-to-project reference.
Example: **dotnet add reference ../MyOtherProject/MyOtherProject.csproj** adds a reference to another project.
- **remove package**: Removes a NuGet package reference from the project.
Example: **dotnet remove package Newtonsoft.Json** removes the Newtonsoft.Json package from the project.
- **remove reference**: Removes a project-to-project reference.
Example: **dotnet remove reference ../MyOtherProject/MyOtherProject.csproj** removes a reference to another project.
- **list package**: Lists all NuGet packages referenced in the project.
Example: **dotnet list package** lists all packages in the current project.
- **list reference**: Lists all project-to-project references.
Example: **dotnet list reference** lists all project references in the current project.

**NuGet Commands**

- **nuget delete**: Deletes or unlists a package from a server.
Example: **dotnet nuget delete MyPackage 1.0.0 --source <https://api.nuget.org/v3/index.json>** deletes version 1.0.0 of "MyPackage" from NuGet.
- **nuget locals**: Manages NuGet local resources (e.g., cache, temp files).
Example: **dotnet nuget locals all --clear** clears all local NuGet caches.
- **nuget push**: Pushes a package to a server.
Example: **dotnet nuget push MyPackage.1.0.0.nupkg --source <https://api.nuget.org/v3/index.json>** pushes the specified package to NuGet.
- **nuget source management**: Commands to add, disable, enable, list, remove, or update NuGet sources.
Example: **dotnet nuget list source** lists all NuGet package sources.
- **nuget verify**: Verifies the package's authenticity and integrity.
Example: **dotnet nuget verify MyPackage.1.0.0.nupkg** verifies the specified package.
- **nuget trust**: Manages trusted certificates and packages.
Example: **dotnet nuget trust --list** lists trusted packages and certificates.
- **nuget sign**: Signs a NuGet package.
Example: **dotnet nuget sign MyPackage.1.0.0.nupkg --certificate-path mycert.pfx** signs the specified package with a certificate.
- **package search**: Searches for NuGet packages (new since .NET 8.0.2xx SDK).
Example: **dotnet package search "Newtonsoft.Json"** searches for NuGet packages with the name "Newtonsoft.Json".

**Workload Management Commands**

- **workload**: Manages .NET workloads (available since .NET 7 SDK).
Example: **dotnet workload list** lists available workloads.
- **workload install**: Installs a workload.
Example: **dotnet workload install wasm-tools** installs the WebAssembly tools workload.
- **workload update**: Updates workloads.
Example: **dotnet workload update** updates installed workloads.
- **workload restore**: Restores installed workloads.
Example: **dotnet workload restore** restores workloads for the current project.
- **workload repair**: Repairs installed workloads.
Example: **dotnet workload repair** repairs issues with installed workloads.
- **workload uninstall**: Uninstalls a workload.
Example: **dotnet workload uninstall wasm-tools** uninstalls the WebAssembly tools workload.
- **workload search**: Searches for available workloads.
Example: **dotnet workload search "wasm"** searches for workloads related to WebAssembly.

**Advanced Commands**

- **sdk check**: Checks the current .NET SDK installation.
Example: **dotnet --list-sdks** lists all installed SDKs.
- **msbuild**: Runs MSBuild tasks for .NET projects.
Example: **dotnet msbuild /p:Configuration=Release** builds the current project in release mode using MSBuild.
- **build-server**: Interacts with the build server.
Example: **dotnet build-server shutdown** shuts down the build server.
- **dev-certs**: Manages development certificates.
Example: **dotnet dev-certs https --clean** cleans up development certificates for HTTPS.
- **dotnet install script**: Downloads and installs .NET CLI.
Example: **dotnet-install** downloads and installs the latest .NET SDK.

**Tool Management Commands**

- **tool install**: Installs a tool globally or locally.
Example: **dotnet tool install -g dotnet-ef** installs the Entity Framework Core tools globally.
- **tool list**: Lists installed tools.
Example: **dotnet tool list** lists installed tools for the current project.
- **tool update**: Updates installed tools.
Example: **dotnet tool update -g dotnet-ef** updates the Entity Framework Core tools globally.
- **tool restore**: Restores tools for a project.
Example: **dotnet tool restore** restores tools listed in the project file.
- **tool run**: Runs a tool.
Example: **dotnet tool run dotnet-ef migrations add InitialCreate** runs the Entity Framework Core tool to add a migration.
- **tool uninstall**: Uninstalls a tool.
Example: **dotnet tool uninstall -g dotnet-ef** uninstalls the Entity Framework Core tools globally.
- **tool search**: Searches for available tools.
Example: **dotnet tool search "ef"** searches for tools related to Entity Framework.

Note: Command add cs project in solution (for management)

```bash
Get-ChildItem -Path .\2.DataStructureAndAlgorithm\ -Filter *.csproj -Recurse | ForEach-Object { dotnet sln add $_.FullName }
```
