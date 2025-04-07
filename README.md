# C# Serilog Introduction Course

## [1 - Introduction to Logging](INTRODUCTION-TO-LOGGING.md)

- Quick chat Logging
- Quick look at the in built logger and limitations

## [2 - Introduction to Serilog](SERILOG.md)

- Quick runthrough

## 4 - [Getting started with Serilog](https://github.com/uerbzr/csharp-webapi)

- Build a webapi project with logging either:
	- From Scratch ? 
	- [Using the provided solution](https://github.com/uerbzr/csharp-webapi) ?
	
- Add Serilog to output to Console

## [5 - Sinks](SERILOG-SINKS.md)

- Add other sinks e.g. File

## Resources

- [Official Microsoft Logging](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/logging/?view=aspnetcore-9.0)
- [Serilog Documentation](https://serilog.net/)
- [Available Sinks](https://github.com/serilog/serilog/wiki/provided-sinks)
- [Log Levels](4-LOGLEVELS.md)

## Useful Commands

- `mkdir project-name` create directory
- `cd project-name` cd into directory

- Setup a .Net Solution
  - `dotnet new sln --name workshop` creates solution file
  - `dotnet new webapi --name workshop.webapi` creates webapi project
  - `dotnet sln add **/*.csproj` adds all csprojs to sln
  - `start devenv workshop.sln` to open in Visual Studio
- `dotnet new gitignore`
- `touch README.md` always put a readme in there
