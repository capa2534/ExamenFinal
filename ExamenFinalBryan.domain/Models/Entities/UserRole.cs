using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.domain.Models.Entities
{
    public class UserRole
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public bool Selected { get; set; }
    }
}
