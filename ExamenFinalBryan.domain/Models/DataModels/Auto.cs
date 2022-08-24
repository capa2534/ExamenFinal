using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalBryan.domain.Models.DataModels
{
    public class Auto
    {

        public Auto()
        {
        }

        public Auto(int id, string nombre)
        {
            Id = id;
            Placa = nombre;
        }

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Colocar el numero de Placa.")]
        public string Placa { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El Nombre de la Marca es requerido.")]
        public string Marca { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El Nombre del Modelo es requerido.")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "La longitud del Modelo debe ser entre 3 y 40 catacteres.")]
        public string Modelo { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El año son requerido.")]
        [StringLength(4, MinimumLength = 3, ErrorMessage = "La longitud del año deben ser entre 3 y 4 catacteres.")]
        public string Annio { get; set; }

        [Required(ErrorMessage = "El Precio es requerido")]
        public int Precio { get; set; }

        public string Estado { get; set; }


    }
}
