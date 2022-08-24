using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalBryan.domain.Models.DataTransferModels
{

    public class Elemento2
    {
        public Elemento2()
        {

        }

        /// <summary>
        /// Construye una instancia del Elemento2.
        /// </summary>
        /// <param name="id">Id único del Elemento2.</param>
        /// <param name="cedula">Nombre del Elemento2.</param>
        public Elemento2(int id, int cedula)
        {
            Id = id;
            Cedula = cedula;
        }

        /// <summary>
        /// Asigna u Obtiene el Id del Elemento2.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Asigna u Obtiene el Nombre del Elemento2.
        /// </summary>
        public int Cedula { get; set; }
    }
}
