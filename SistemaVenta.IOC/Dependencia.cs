using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using SistemaVenta.DALL.DBContext;
using Microsoft.EntityFrameworkCore;


using SistemaVenta.DAL.Implementacion;
using SistemaVenta.DAL.Interfaces;
using SistemaVenta.BLL.Implementacion;
using SistemaVenta.BLL.Interfaces;

namespace SistemaVenta.IOC
{
    public static class Dependencia
    {
        public static void InyectarDependencia(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<DBVENTAContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("CADENASQL"));
            });

            // services.AddTransien varian sus valores
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            // Inyeccion de dependencias para IVentaRepository y VentaRepository
            services.AddScoped<IVentaRepository, VentaRepository>();

            // Ddependencia de eenvio de correo
            services.AddScoped<ICorreoService, CorreoService>();
        }
    }
}
