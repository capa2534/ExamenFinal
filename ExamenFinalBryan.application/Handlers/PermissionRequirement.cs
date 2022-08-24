using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.application.Handlers
{
    public class PermissionRequirement : IAuthorizationRequirement
    {
        public PermissionRequirement(PermissionTypes permissionType)
        {
            PermissionType = permissionType;
        }

        public PermissionTypes PermissionType { get; private set; }
    }
}
