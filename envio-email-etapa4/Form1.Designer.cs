namespace evio_email_etapa3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelRA;
        private TextBox textBoxRA;
        private Button btnEnviarEmail;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelRA = new Label();
            this.textBoxRA = new TextBox();
            this.btnEnviarEmail = new Button();
            this.SuspendLayout();
            // 
            // labelRA
            // 
            this.labelRA.AutoSize = true;
            this.labelRA.Location = new System.Drawing.Point(50, 50);
            this.labelRA.Name = "labelRA";
            this.labelRA.Size = new System.Drawing.Size(35, 13);
            this.labelRA.TabIndex = 0;
            this.labelRA.Text = "RA:";
            // 
            // textBoxRA
            // 
            this.textBoxRA.Location = new System.Drawing.Point(100, 50);
            this.textBoxRA.Name = "textBoxRA";
            this.textBoxRA.Size = new System.Drawing.Size(200, 20);
            this.textBoxRA.TabIndex = 1;
            // 
            // btnEnviarEmail
            // 
            this.btnEnviarEmail.Location = new System.Drawing.Point(100, 100);
            this.btnEnviarEmail.Name = "btnEnviarEmail";
            this.btnEnviarEmail.Size = new System.Drawing.Size(100, 30);
            this.btnEnviarEmail.TabIndex = 2;
            this.btnEnviarEmail.Text = "Enviar Email";
            this.btnEnviarEmail.UseVisualStyleBackColor = true;
            this.btnEnviarEmail.Click += new System.EventHandler(this.btnEnviarEmail_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.labelRA);
            this.Controls.Add(this.textBoxRA);
            this.Controls.Add(this.btnEnviarEmail);
            this.Name = "Form1";
            this.Text = "Enviar Email por RA";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
