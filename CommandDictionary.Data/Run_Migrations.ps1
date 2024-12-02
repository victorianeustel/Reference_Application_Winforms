(Get-Location).path
try {
    dotnet ef database update
}
catch{
    "An error occurred while attempting to run migrations"
}

Read-Host "Press Enter to exit..."