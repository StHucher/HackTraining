# HackTraining

1- mkdir BackEnd && cd BackEnd
2- cd BackEnd
3- dotnet new webapi 
4- npm create vite frontend
5-  cd frontend
  npm install
  npm run dev
6- Create Models

Installing packages in BackEnd terminal! (cd backend)

7- dotnet tool install -g dotnet-aspnet-codegenerator
8- dotnet tool install -g dotnet-ef
9- dotnet add package Microsoft.EntityFrameworkCore
10- dotnet add package Microsoft.EntityFrameworkCore.Design
11- dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
12- dotnet add package Microsoft.EntityFrameworkCore.SqlServer
13- dotnet add package Microsoft.EntityFrameworkCore.Tools
14- dotnet aspnet-codegenerator controller -name CustomersController -async -api -m Customer -dc ApplicationDbContext --relativeFolderPath Controllers
15- dotnet aspnet-codegenerator controller -name AddressesController -async -api -m Address -dc ApplicationDbContext --relativeFolderPath Controllers
16- dotnet run
17- Paste in appsettings.json 
"ConnectionStrings": {
    "ApplicationDbContext": "Server=localhost,1433;Database=TestDataBase;User Id=sa;Password=Password_2_Change_4_Real_Cases_&;TrustServerCertificate=True;"
  }
18-Add migration: dotnet ef migrations add FirstMigration
19-Update: dotnet ef database update

Feed the DB with Bogus data
Create a class SeedDataBogus in Data folder
20- dotnet add package bogus
21-In program.cs Add scope:
using (var scope = app.Services.CreateScope())
{
  var services = scope.ServiceProvider;
  SeedDataBogus.Initialize(services);
}

22- Add CORS to PRogram.cs to share the IP address with FrontEnd
23- To run the VITE from the frontEnd project : npm run dev
24-Create Types as in the Db
25-Create the API