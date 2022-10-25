using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using SistemaVenta.DALL.DBContext;
using Microsoft.EntityFrameworkCore;
// using SistemaVenta.DALL.Implementacion;
// using SistemaVenta.DALL.Interfaces;
// using SistemaVenta.BLL.Implementacion;
// using SistemaVenta.BLL.Interfaces;

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
        }
    }
}
