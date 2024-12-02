(Get-Location).path
Write-Host "`n"

try {
    dotnet ef database update
}
catch{
    "An error occurred while attempting to run migrations"  
    Write-Host $_
    Write-Host "`n"
    Read-Host "Press Enter to exit..."
}

