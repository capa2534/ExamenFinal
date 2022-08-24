using Proyecto.domain.Models.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.application.Contracts
{
    public interface IApplicationDbContext
    {
        DbSet<Empleado> Empleados { get; set; }

        DbSet<Cliente> Clientes { get; set; }

        DbSet<Auto> Autos { get; set; }

        DbSet<Ventas> Ventas { get; set; }

    }
}
