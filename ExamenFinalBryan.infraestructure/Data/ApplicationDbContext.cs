using Proyecto.application.Contracts;
using Proyecto.domain.Models.DataModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.infraestructure.Data
{
    public class ApplicationDbContext: IdentityDbContext<IdentityUser>, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Empleado> Empleados { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Auto> Autos { get; set; }
        public DbSet<Ventas> Ventas { get; set; }


    }
}
