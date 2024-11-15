using System;

// Esta classe gerará as credenciais do responsável.

namespace evio_email_etapa3.Services
{
    public class CredenciaisService
    {
        public string GerarCredencial()
        {
            return Guid.NewGuid().ToString("N").Substring(0, 8);
        }
    }
}
