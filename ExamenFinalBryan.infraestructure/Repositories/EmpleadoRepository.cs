using Proyecto.domain.Models.DataModels;
using Proyecto.infraestructure.Data;
using Proyecto.infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.infraestructure.Repositories
{
    public class EmpleadoRepository : Repository<Empleado>, IRepository<Empleado>
    {

        public EmpleadoRepository(ApplicationDbContext context)
            : base(context)
        {

        }
    }
}
