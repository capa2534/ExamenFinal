using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.domain.Models.Enums
{
    public enum Generos
    {
        [Display(Name = "Masculino")]
        MASCULINO = 1,
        [Display(Name = "Femenino")]
        FEMENINO
    }
}
