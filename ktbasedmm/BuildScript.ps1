param (
    [string]$version = '1.0.0',
    [string]$configuration = 'Release'
)

# Check if the version is provided
if (-not $version) {
    Write-Host "Warning: Version argument is empty, building with default version 1.0.0"
}
if (-not $configuration) {
    Write-Host "Warning: configuration argument is empty, building with default configuration "
}

# Define the project directory (modify this path as needed)
$solutionFile = "KtBaseDmm.sln" # We Change this to our project path

# Navigate to the project directory
#cd $projectPath

# Build the project using the provided version and configuration
Write-Host "Building the .NET project with version: $version and configuration: $configuration"

# Set the version and perform the build
$buildCommand = "dotnet build --configuration $configuration /p:Version=$version"

try {
    Invoke-Expression $buildCommand
    Write-Host "Build completed successfully."
} catch {
    Write-Host "Build failed: $_"
}
