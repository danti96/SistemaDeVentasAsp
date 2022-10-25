
👉Instalación de paquetes de nuget

- microsoft.entityframeworkcore.sqlserver
- microsoft.entityframeworkcore.tools

👉Comando Entity Framework:
# https://www.entityframeworktutorial.net/efcore/create-model-for-existing-database-in-ef-core.aspx
Usar Scaffold-DbContext para crear un modelo basado en su base de datos existente. Los siguientes
parámetros se pueden especificar con Scaffold-DbContext en la consola del Administrador de paquetes:

    Scaffold-DbContext [-Connection] [-Provider] [-OutputDir] [-Context] [-Schemas>] [-Tables>] 
                        [-DataAnnotations] [-Force] [-Project] [-StartupProject] [<CommonParameters>]

En Visual Studio, seleccione el menú Herramientas -> NuGet Package Manger -> Package Manger Console y
ejecute el siguiente comando:

    Scaffold-DbContext "Server=DESKTOP-D7BNDHP; DataBase=DBVENTA;Integrated Security=true" Microsoft.EntityFrameworkCore.SqlServer

