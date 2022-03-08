using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SUC.Infra.Data.PostgresSQL.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SUC.Api.Configurations
{
    public class EntityFrameworkConfiguration
    {
        public static void AddPostgreSQLEntityFramework(IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("SUC_BD");

            services.AddEntityFrameworkNpgsql()
                .AddDbContext<SqlContext>(opt => opt.UseNpgsql(connectionString));
        }
    }
}
