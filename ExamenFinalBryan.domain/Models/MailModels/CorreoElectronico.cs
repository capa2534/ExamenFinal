﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalBryan.domain.Models.MailModels
{
    public class CorreoElectronico
    {
        public string Destinatario { get; set; }

        public string Asunto { get; set; }

        public string Cuerpo { get; set; }
    }
}
