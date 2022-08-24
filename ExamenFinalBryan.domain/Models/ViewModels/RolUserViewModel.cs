using Proyecto.domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.domain.Models.ViewModels
{
    public class RoleUserViewModel
    {
        public RoleUserViewModel()
        {
            Roles = new List<RoleUser>();
        }



        public string UserId { get; set; }



        public IList<RoleUser> Roles { get; set; }
    }
}
