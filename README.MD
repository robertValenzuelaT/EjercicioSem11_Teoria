STARTUP.CS

using Npgsql.EntityFrameworkCore.PostgreSQL;
using Microsoft.EntityFrameworkCore;

**********************************************************

dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 5.0.10
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 5.0.10 
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 5.0.10

dotnet tool install --global dotnet-ef (tool que se instala una vez en la vida)
dotnet ef migrations add inicial