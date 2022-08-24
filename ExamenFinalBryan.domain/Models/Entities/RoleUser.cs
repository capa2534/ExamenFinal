using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.domain.Models.Entities
{
    public class RoleUser
    {
        [Required]
        public string Role { get; set; }

        public bool Selected { get; set; }
    }
}
