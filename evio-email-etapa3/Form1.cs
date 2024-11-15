using System;
using System.Windows.Forms;

namespace evio_email_etapa3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Este é o método gerado automaticamente pelo Visual Studio.
            CriarBotoes();        // Método manual para adicionar lógica customizada.
        }

        private void CriarBotoes()
        {
            // Botão 1 - CONSULTAR
            Button botao1 = new Button();
            botao1.Text = "CONSULTAR";
            botao1.Name = "CONSULTAR";
            botao1.Location = new System.Drawing.Point(50, 50);
            botao1.Click += (sender, e) => MessageBox.Show("AGORA É COM VC FELIPA");

            // Botão 2 - MENU
            Button botao2 = new Button();
            botao2.Text = "MENU";
            botao2.Name = "MENU";
            botao2.Location = new System.Drawing.Point(50, 100);
            botao2.Click += (sender, e) => MessageBox.Show("AGORA É COM VC FELIPA");

            // Adiciona os botões ao Formulário
            this.Controls.Add(botao1);
            this.Controls.Add(botao2);
        }
    }
}
