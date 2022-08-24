using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.domain.Models.Entities
{
    public class User
    {
        public string Id { get; set; }

        [Required]
        public string Email { get; set; }

    }
}
