namespace SistemaBancario
{
    partial class FormVisaoDasContas
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.verContas = new System.Windows.Forms.Button();
            this.button1ExcluirConta = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3EditarConta = new System.Windows.Forms.Button();
            this.button4Voltar = new System.Windows.Forms.Button();
            this.button5EntrarNaConta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(358, 316);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // verContas
            // 
            this.verContas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verContas.Location = new System.Drawing.Point(12, 392);
            this.verContas.Name = "verContas";
            this.verContas.Size = new System.Drawing.Size(142, 46);
            this.verContas.TabIndex = 1;
            this.verContas.Text = "Ver Contas";
            this.verContas.UseVisualStyleBackColor = true;
            this.verContas.Click += new System.EventHandler(this.VerContas_Click);
            // 
            // button1ExcluirConta
            // 
            this.button1ExcluirConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1ExcluirConta.Location = new System.Drawing.Point(228, 392);
            this.button1ExcluirConta.Name = "button1ExcluirConta";
            this.button1ExcluirConta.Size = new System.Drawing.Size(142, 46);
            this.button1ExcluirConta.TabIndex = 2;
            this.button1ExcluirConta.Text = "Excluir Conta";
            this.button1ExcluirConta.UseVisualStyleBackColor = true;
            this.button1ExcluirConta.Click += new System.EventHandler(this.Button1ExcluirConta_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(646, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ver Contas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3EditarConta
            // 
            this.button3EditarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3EditarConta.Location = new System.Drawing.Point(12, 392);
            this.button3EditarConta.Name = "button3EditarConta";
            this.button3EditarConta.Size = new System.Drawing.Size(142, 46);
            this.button3EditarConta.TabIndex = 1;
            this.button3EditarConta.Text = "Editar Conta";
            this.button3EditarConta.UseVisualStyleBackColor = true;
            this.button3EditarConta.Click += new System.EventHandler(this.Button3EditarConta_Click);
            // 
            // button4Voltar
            // 
            this.button4Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4Voltar.Location = new System.Drawing.Point(646, 392);
            this.button4Voltar.Name = "button4Voltar";
            this.button4Voltar.Size = new System.Drawing.Size(142, 46);
            this.button4Voltar.TabIndex = 4;
            this.button4Voltar.Text = "Voltar";
            this.button4Voltar.UseVisualStyleBackColor = true;
            this.button4Voltar.Click += new System.EventHandler(this.Button4Voltar_Click);
            // 
            // button5EntrarNaConta
            // 
            this.button5EntrarNaConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5EntrarNaConta.Location = new System.Drawing.Point(435, 392);
            this.button5EntrarNaConta.Name = "button5EntrarNaConta";
            this.button5EntrarNaConta.Size = new System.Drawing.Size(142, 46);
            this.button5EntrarNaConta.TabIndex = 3;
            this.button5EntrarNaConta.Text = "Entrar Na Conta";
            this.button5EntrarNaConta.UseVisualStyleBackColor = true;
            this.button5EntrarNaConta.Click += new System.EventHandler(this.Button5EntrarNaConta_Click);
            // 
            // FormVisaoDasContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4Voltar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3EditarConta);
            this.Controls.Add(this.button5EntrarNaConta);
            this.Controls.Add(this.button1ExcluirConta);
            this.Controls.Add(this.verContas);
            this.Controls.Add(this.listBox1);
            this.Name = "FormVisaoDasContas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lista de Contas";
            this.Load += new System.EventHandler(this.VisaoDasContas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button verContas;
        private System.Windows.Forms.Button button1ExcluirConta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3EditarConta;
        private System.Windows.Forms.Button button4Voltar;
        private System.Windows.Forms.Button button5EntrarNaConta;
    }
}