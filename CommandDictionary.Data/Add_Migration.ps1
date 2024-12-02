(Get-Location).path
Write-Host "`n"
$inputMigrationName = Read-Host "Enter name for new migration"
$titleCaseName = (Get-Culture).TextInfo.ToTitleCase($inputMigrationName)
$normalizedMigrationName = $titleCaseName.Trim().Replace(" ", "_")

try {
    dotnet ef migrations add $normalizedMigrationName
}
catch{
    "An error occurred while attempting to create migration"
    Write-Host $_
    Write-Host "`n"
    Read-Host "Press Enter to exit..."
}

