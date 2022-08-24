using ExamenFinalBryan.domain.Models.DataModels;
using ExamenFinalBryan.infraestructure.Data;
using ExamenFinalBryan.infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalBryan.infraestructure.Repositories
{
    public class VentasRepository : Repository<Ventas>, IRepository<Ventas>
    {
        public VentasRepository(ApplicationDbContext context)
           : base(context)
        {

        }
    }
}
