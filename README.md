# HackTraining

1- mkdir BackEnd
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