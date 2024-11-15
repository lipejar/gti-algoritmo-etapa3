using System;
using System.Windows.Forms;
using evio_email_etapa3.Services;
using evio_email_etapa3.Models;

namespace evio_email_etapa3
{
    public partial class Form1 : Form
    {
        private readonly AlunoService _alunoService;
        private readonly CredenciaisService _credenciaisService;
        private readonly MarkdownService _markdownService;
        private readonly EmailService _emailService;

        public Form1()
        {
            InitializeComponent();
            _alunoService = new AlunoService(); 
            _credenciaisService = new CredenciaisService();
            _markdownService = new MarkdownService();
            _emailService = new EmailService();
        }

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            string ra = textBoxRA.Text.Trim(); 

            if (string.IsNullOrEmpty(ra))
            {
                MessageBox.Show("Por favor, insira um RA válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Consulta o aluno
                Aluno aluno = _alunoService.ConsultarAluno(ra);
                if (aluno == null)
                {
                    throw new Exception("Aluno não encontrado!");
                }

                // Gera a credencial para o responsável
                string credenciais = _credenciaisService.GerarCredencial();
                Console.WriteLine($"Credenciais geradas: {credenciais}");

                // Gera o markdown para o e-mail
                string markdown = _markdownService.GerarEmailMarkdown(aluno.NomeResponsavel, aluno.Nome, credenciais);
                Console.WriteLine($"Markdown gerado:\n{markdown}");

                // Envia o e-mail e salva o markdown
                _emailService.EnviarEmail(ra, markdown);

                // Mensagem de sucesso
                MessageBox.Show("Email enviado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao enviar email: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
