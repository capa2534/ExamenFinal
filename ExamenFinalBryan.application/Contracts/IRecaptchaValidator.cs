using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalBryan.application.Contracts
{
    public interface IRecaptchaValidator
    {
        bool Validate(string token);
    }
}
