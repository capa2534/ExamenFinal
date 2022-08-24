using Proyecto.application.Contracts;
using Proyecto.domain.Models.ConfigurationsModels;
using Proyecto.domain.Models.PlainModels;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Proyecto.application.Components
{
    public class RecaptchaValidator : IRecaptchaValidator
    {
        public RecaptchaValidator(IOptions<ConfiguracionRecaptcha> configuracion)
        {
            Configuracion = configuracion.Value;
        }
        ConfiguracionRecaptcha Configuracion;
        public bool Validate(string response)
        {
            //nos conectamos a Google para ver si el token es válido
            string address =
                string.Format
                    ("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}", Configuracion.SecretKey, response);
            Uri uri = new Uri(address);
            try
            {
                WebClient client = new WebClient();
                string result = client.DownloadString(uri);
                var options =
                    new JsonSerializerOptions
                    {
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                        PropertyNameCaseInsensitive = true
                    };
                RecaptchaModel model = JsonSerializer.Deserialize<RecaptchaModel>(result, options);
                if (!model.Success)
                {
                    string exceptionMessage = string.Empty;
                    foreach (var errorCode in model.ErrorCodes)
                    {
                        exceptionMessage += string.Concat(errorCode, "\n");
                    }
                    throw new Exception(exceptionMessage);
                }
                return true;
            }
            catch
            {
                throw;
            }
        }
    }

}
