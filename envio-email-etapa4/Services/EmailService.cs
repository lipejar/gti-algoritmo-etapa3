using System;
using System.IO;

//Esta classe simulará o envio do e-mail

namespace evio_email_etapa3.Services
{
    public class EmailService
    {
        public void EnviarEmail(string ra, string markdown)
        {
            Console.WriteLine("E-mail enviado com sucesso!");
            File.WriteAllText($"{ra}.md", markdown);
        }
    }
}
