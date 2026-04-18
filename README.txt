# EF01G01 — EF Core Code First Project

## Steps to run in Visual Studio:

1. Open Visual Studio
2. File → Open → Project/Solution
3. Choose the file: EF01G01.csproj
4. Wait for NuGet packages to restore automatically

## Run Migrations (Package Manager Console):
   Tools → NuGet Package Manager → Package Manager Console

   Add-Migration "InitialCreate"
   Update-Database

## OR just run the project directly:
   Press F5 — it will create the database using EnsureCreated()

## Connection String:
   Server=.; Database=EF01G01; Trusted_Connection=True; TrustServerCertificate=True
