using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalBryan.domain.Models.MailModels
{
    public interface ICartero
    {
        void Enviar(CorreoElectronico correo);
    }
}
