# PrototypePlayground
### There are three projects in this workspace

## Project 1: IVI.NET Shared Components: Ivi.DriverCore 

TODO: Rename "Ivi.DriverCore". A couple of options

Option 1: IVI.NET

Option 2: IVI.NETCore

Specification Referred: IviDriverNet Version 0.1

IVI.NET Shared Components (Dual targeted) Project

The IVI.NET Shared Components are required for use or development of IVI.NET drivers. This project generates dual-targeted IVI.NET Shared Components.

##### Build with PowerShell Script
To build these components, clone the repository, navigate to directory ../../Ivi.DriverCore, and run powershell script "SharedComponentBuildScript.ps1". For instance 

```sh
.\SharedComponentBuildScript.ps1 -configuration $configuration -version $sharedVersion
```
Configuration: Debug|Release

Version: 1.0.0 (three digit)

Output: When build is triggered it will create a nuget package along with dual targeted assemblies.
Currently supported targets are 4.6.2 and 6.0

## Project 2: Prototype Driver 1: KtIviNetDriver  

Driver Name: KtIviNetDriver  

Dual-Targeted: .NET4.6.2 and 6.0.

Specification Referred: IviDriverCore Version:0.1    IviDriverNet Version 0.1

Details: A prototype driver that uses latest IVI Core specs and consumes the latest IVI.NET Shared Components.
The driver solution can be built using powershell script with switches (explained below). 

##### Build with PowerShell Script
To build this driver, clone the repository, navigate to directory ../../KtIviNetDriver, and run powershell script "DriverBuildScript.ps1" in powershell terminal with commands like 

```sh
.\DriverBuildScript.ps1 -configuration $configuration -sharedVersion $sharedVersion -driverVersion $driverVersion -localNugetFolder $localNugetFolder -sharedComponentBuild $sharedComponentBuild
```

### Switches Explained 

| Switch | Value |
| ------ | ------ |
| configuration |  Release/Debug (default is Release)
| sharedVersion |  X.Y.Z (default is 1.0.0)
| driverVersion |  X.Y.Z (default is 1.0.0)
| localNugetFolder |  Path to Nuget package of shared components (default path is ..\..\NugetPackage)
| sharedComponentBuild |  1 or 0 (default is 0, if set to 1 it will build shared componets too)

## Project 3: Prototype Driver 2: KtBaseDmm  (DMM Class added)
TBD


