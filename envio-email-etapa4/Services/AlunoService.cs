using evio_email_etapa3.Models;
using System.Linq;

namespace evio_email_etapa3.Services
{
    public class AlunoService
    {
        private readonly Aluno[] alunos = new Aluno[]
        {
            new Aluno { RA = "123", Nome = "João", NomeResponsavel = "Maria", EmailResponsavel = "maria@yahoo.com.br" },
            new Aluno { RA = "456", Nome = "Maria", NomeResponsavel = "Carlos", EmailResponsavel = "carlos@hotmail.com" },
            new Aluno { RA = "789", Nome = "Felipe", NomeResponsavel = "José", EmailResponsavel = "jose@gmail.com" },
            new Aluno { RA = "846", Nome = "Cristiano", NomeResponsavel = "Lucas", EmailResponsavel = "lucas@gmail.com"}
        };

        public Aluno ConsultarAluno(string ra)
        {
            return alunos.FirstOrDefault(a => a.RA == ra);
        }

        public void ProcessarRA(string ra)
        {
            // Consulta o aluno pelo RA.
            Aluno aluno = ConsultarAluno(ra);

            if (aluno == null)
                throw new Exception("Aluno não encontrado!");

            // Simulação do envio de email.
            string emailMensagem = $"Olá {aluno.NomeResponsavel}, este é um email sobre o(a) aluno(a) {aluno.Nome}.";
            System.Diagnostics.Debug.WriteLine($"Email enviado para {aluno.EmailResponsavel}: {emailMensagem}");
            Console.WriteLine($"Email enviado para {aluno.EmailResponsavel}: {emailMensagem}");
        }
    }
}
