param (
    [string]$sharedVersion = '1.0.0',
	[string]$driverVersion = '1.0.0',
    [string]$configuration = 'Release',
	[string]$localNugetFolder = '..\..\NugetPackage',
	[bool]$sharedComponentBuild = $false
)
if (-not $localNugetFolder -or $sharedComponentBuild) {

cd ..\Ivi.DriverCore
& .\SharedComponentBuildScript.ps1 -configuration $configuration -version $sharedVersion
cd ..\..\KtIviNetDriver

# Define the path to the local NuGet package folder
$localNugetFolder = "..\..\Ivi.DriverCore\build\$configuration"
}

# Define the path to the .NET project
$driverProjectPath = ".\KtIviNetDriver\KtIviNetDriver.csproj"

# Step 1: Add the local NuGet package source
Write-Host "Adding local NuGet package source..."
..\..\nuget.exe sources Add -Name LocalNugetSource -Source $localNugetFolder

# Step 2: Restore the packages, including the local one
Write-Host "Restoring NuGet packages..."
dotnet restore $driverProjectPath --source $localNugetFolder

# Step 3: Build the .NET project
Write-Host "Building the .NET project..."
$driverBuildCommand = 'dotnet build $driverProjectPath --configuration $configuration /p:Version=$driverVersion'
try {
    Invoke-Expression $driverBuildCommand
    Write-Host "Driver  version $driverVersion build completed successfully."
} catch {
    Write-Host "Build failed: $_"
}
# Step 4: Clean up the added source 
 Write-Host "Removing the local NuGet source..."
..\..\nuget.exe sources Remove -Name LocalNugetSource

Write-Host "Build process completed."

