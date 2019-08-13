namespace SistemaBancario
{
    partial class FormSistemaBancario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sairSistema = new System.Windows.Forms.Button();
            this.verContas = new System.Windows.Forms.Button();
            this.criarConta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sairSistema
            // 
            this.sairSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairSistema.Location = new System.Drawing.Point(526, 399);
            this.sairSistema.Name = "sairSistema";
            this.sairSistema.Size = new System.Drawing.Size(142, 46);
            this.sairSistema.TabIndex = 0;
            this.sairSistema.Text = "Sair do Sistema";
            this.sairSistema.UseVisualStyleBackColor = true;
            this.sairSistema.Click += new System.EventHandler(this.SairSistema_Click);
            // 
            // verContas
            // 
            this.verContas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verContas.Location = new System.Drawing.Point(230, 399);
            this.verContas.Name = "verContas";
            this.verContas.Size = new System.Drawing.Size(142, 46);
            this.verContas.TabIndex = 0;
            this.verContas.Text = "Ver Contas";
            this.verContas.UseVisualStyleBackColor = true;
            this.verContas.Click += new System.EventHandler(this.VerContas_Click);
            // 
            // criarConta
            // 
            this.criarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criarConta.Location = new System.Drawing.Point(378, 399);
            this.criarConta.Name = "criarConta";
            this.criarConta.Size = new System.Drawing.Size(142, 46);
            this.criarConta.TabIndex = 0;
            this.criarConta.Text = "Criar Conta";
            this.criarConta.UseVisualStyleBackColor = true;
            this.criarConta.Click += new System.EventHandler(this.CriarConta_Click);
            // 
            // FormSistemaBancario
            // 
            this.CancelButton = this.sairSistema;
            this.ClientSize = new System.Drawing.Size(898, 457);
            this.Controls.Add(this.criarConta);
            this.Controls.Add(this.verContas);
            this.Controls.Add(this.sairSistema);
            this.Name = "FormSistemaBancario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu:";
            this.Load += new System.EventHandler(this.FormSistemaBancario_Load);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button sairSistema;
        private System.Windows.Forms.Button verContas;
        private System.Windows.Forms.Button criarConta;
    }
}