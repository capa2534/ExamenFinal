using ExamenFinalBryan.domain.Models.DataTransferModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalBryan.domain.Models.DataModels
{

    public class Ventas
    {
        public List<Elemento2> Clientes { get; set; }
        public List<Elemento2> Empleados { get; set; }

        public List<Elemento3> Autos { get; set; }

        public Ventas()
        {
            Empleados = new List<Elemento2>();
            Clientes = new List<Elemento2>();
            Autos = new List<Elemento3>();
        }

        public Ventas(int id)
        {
            Id = id;

        }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime Fecha_hora { get; set; }

        public int Cedula { get; set; }
        public int CedulaEmp { get; set; }
        public string Nombre { get; set; }
        public string NombreEmp { get; set; }
        public string CorreoElectronico { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Annio { get; set; }
        public int Precio { get; set; }


        [ForeignKey("Curso")]
        public int Id_Cliente { get; set; }
        public int Id_Auto { get; set; }
        public int Id_Empleado { get; set; }


    }
}
