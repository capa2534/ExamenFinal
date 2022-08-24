using Proyecto.infraestructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.infraestructure
{
    public static class Injection
    {
        public static IServiceCollection RegisterInfrastructureServices
            (this IServiceCollection services, IConfiguration configuration)
        {

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddTokenProvider<DataProtectorTokenProvider<IdentityUser>>
                    (TokenOptions.DefaultProvider);

            

            return services;
        }
    }
}
