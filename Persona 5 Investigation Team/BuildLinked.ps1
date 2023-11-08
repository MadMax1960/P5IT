# Set Working Directory
Split-Path $MyInvocation.MyCommand.Path | Push-Location
[Environment]::CurrentDirectory = $PWD

Remove-Item "$env:RELOADEDIIMODS/Persona_5_Investigation_Team/*" -Force -Recurse
dotnet publish "./Persona_5_Investigation_Team.csproj" -c Release -o "$env:RELOADEDIIMODS/Persona_5_Investigation_Team" /p:OutputPath="./bin/Release" /p:ReloadedILLink="true"

# Restore Working Directory
Pop-Location