namespace evio_email_etapa3.Services
{
    public class MarkdownService
    {
        public string GerarEmailMarkdown(string nomeResponsavel, string nomeAluno, string credenciais)
        {
            return $@"
# Bem-vindo ao Colégio!

Olá {nomeResponsavel},

Parabéns pela matrícula de {nomeAluno}. 
Segue abaixo as credenciais de acesso:

**Credenciais:** {credenciais}

Atenciosamente,  
Equipe do Colégio.
";
        }
    }
}
