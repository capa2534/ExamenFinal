using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.application.Handlers
{
    public enum PermissionTypes
    {
        [Description(PermissionTypeNames.VIEWROLES)]
        VIEWROLES,

        [Description(PermissionTypeNames.WRITEROLES)]
        WRITEROLES,

        [Description(PermissionTypeNames.MANAGEROLES)]
        MANAGEROLES

    }
}
