using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalBryan.domain.Models.DataTransferModels
{

    public class Elemento3
    {
        public Elemento3()
        {

        }

        /// <summary>
        /// Construye una instancia del Elemento.
        /// </summary>
        /// <param name="id">Id único del Elemento.</param>
        /// <param name="placa">Nombre del Elemento.</param>
        public Elemento3(int id, string placa)
        {
            Id = id;
            Placa = placa;
        }

        /// <summary>
        /// Asigna u Obtiene el Id del Elemento.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Asigna u Obtiene el Nombre del Elemento.
        /// </summary>
        public string Placa { get; set; }
    }
}
