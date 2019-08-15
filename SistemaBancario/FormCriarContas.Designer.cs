namespace SistemaBancario
{
    partial class FormCriarContas
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
            this.caixadeNome = new System.Windows.Forms.TextBox();
            this.caixadeNumero = new System.Windows.Forms.TextBox();
            this.caixadeEndereco = new System.Windows.Forms.TextBox();
            this.caixadeRg = new System.Windows.Forms.TextBox();
            this.caixadeCpf = new System.Windows.Forms.TextBox();
            this.caixadeSaldo = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.Label();
            this.endereço = new System.Windows.Forms.Label();
            this.rg = new System.Windows.Forms.Label();
            this.cpf = new System.Windows.Forms.Label();
            this.saldo = new System.Windows.Forms.Label();
            this.criarESalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // caixadeNome
            // 
            this.caixadeNome.Location = new System.Drawing.Point(241, 136);
            this.caixadeNome.Name = "caixadeNome";
            this.caixadeNome.Size = new System.Drawing.Size(353, 20);
            this.caixadeNome.TabIndex = 0;
            this.caixadeNome.TextChanged += new System.EventHandler(this.CaixadeNome_TextChanged);
            // 
            // caixadeNumero
            // 
            this.caixadeNumero.Location = new System.Drawing.Point(241, 162);
            this.caixadeNumero.Name = "caixadeNumero";
            this.caixadeNumero.Size = new System.Drawing.Size(353, 20);
            this.caixadeNumero.TabIndex = 1;
            this.caixadeNumero.TextChanged += new System.EventHandler(this.CaixadeNumero_TextChanged);
            // 
            // caixadeEndereco
            // 
            this.caixadeEndereco.Location = new System.Drawing.Point(241, 188);
            this.caixadeEndereco.Name = "caixadeEndereco";
            this.caixadeEndereco.Size = new System.Drawing.Size(353, 20);
            this.caixadeEndereco.TabIndex = 2;
            this.caixadeEndereco.TextChanged += new System.EventHandler(this.CaixadeEndereco_TextChanged);
            // 
            // caixadeRg
            // 
            this.caixadeRg.Location = new System.Drawing.Point(241, 214);
            this.caixadeRg.Name = "caixadeRg";
            this.caixadeRg.Size = new System.Drawing.Size(353, 20);
            this.caixadeRg.TabIndex = 3;
            this.caixadeRg.TextChanged += new System.EventHandler(this.CaixadeRg_TextChanged);
            // 
            // caixadeCpf
            // 
            this.caixadeCpf.Location = new System.Drawing.Point(241, 240);
            this.caixadeCpf.Name = "caixadeCpf";
            this.caixadeCpf.Size = new System.Drawing.Size(353, 20);
            this.caixadeCpf.TabIndex = 4;
            this.caixadeCpf.TextChanged += new System.EventHandler(this.CaixadeCpf_TextChanged);
            // 
            // caixadeSaldo
            // 
            this.caixadeSaldo.Location = new System.Drawing.Point(241, 266);
            this.caixadeSaldo.Name = "caixadeSaldo";
            this.caixadeSaldo.Size = new System.Drawing.Size(353, 20);
            this.caixadeSaldo.TabIndex = 5;
            this.caixadeSaldo.TextChanged += new System.EventHandler(this.CaixadeSaldo_TextChanged);
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(154, 137);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(48, 16);
            this.nome.TabIndex = 1;
            this.nome.Text = "Nome:";
            this.nome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nome.Click += new System.EventHandler(this.Nome_Click);
            // 
            // numero
            // 
            this.numero.AutoSize = true;
            this.numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero.Location = new System.Drawing.Point(154, 163);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(59, 16);
            this.numero.TabIndex = 1;
            this.numero.Text = "Numero:";
            this.numero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.numero.Click += new System.EventHandler(this.Numero_Click);
            // 
            // endereço
            // 
            this.endereço.AutoSize = true;
            this.endereço.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endereço.Location = new System.Drawing.Point(154, 189);
            this.endereço.Name = "endereço";
            this.endereço.Size = new System.Drawing.Size(70, 16);
            this.endereço.TabIndex = 1;
            this.endereço.Text = "Endereço:";
            this.endereço.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.endereço.Click += new System.EventHandler(this.Endereço_Click);
            // 
            // rg
            // 
            this.rg.AutoSize = true;
            this.rg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rg.Location = new System.Drawing.Point(154, 215);
            this.rg.Name = "rg";
            this.rg.Size = new System.Drawing.Size(31, 16);
            this.rg.TabIndex = 1;
            this.rg.Text = "RG:";
            this.rg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rg.Click += new System.EventHandler(this.Rg_Click);
            // 
            // cpf
            // 
            this.cpf.AutoSize = true;
            this.cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpf.Location = new System.Drawing.Point(154, 241);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(34, 16);
            this.cpf.TabIndex = 1;
            this.cpf.Text = "CPF";
            this.cpf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cpf.Click += new System.EventHandler(this.Cpf_Click);
            // 
            // saldo
            // 
            this.saldo.AutoSize = true;
            this.saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldo.Location = new System.Drawing.Point(154, 267);
            this.saldo.Name = "saldo";
            this.saldo.Size = new System.Drawing.Size(47, 16);
            this.saldo.TabIndex = 1;
            this.saldo.Text = "Saldo:";
            this.saldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saldo.Click += new System.EventHandler(this.Saldo_Click);
            // 
            // criarESalvar
            // 
            this.criarESalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criarESalvar.Location = new System.Drawing.Point(311, 346);
            this.criarESalvar.Name = "criarESalvar";
            this.criarESalvar.Size = new System.Drawing.Size(161, 45);
            this.criarESalvar.TabIndex = 6;
            this.criarESalvar.Text = "Criar e Salvar";
            this.criarESalvar.UseVisualStyleBackColor = true;
            this.criarESalvar.Click += new System.EventHandler(this.CriarESalvar_Click);
            // 
            // FormCriarContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.criarESalvar);
            this.Controls.Add(this.saldo);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.rg);
            this.Controls.Add(this.endereço);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.caixadeSaldo);
            this.Controls.Add(this.caixadeCpf);
            this.Controls.Add(this.caixadeRg);
            this.Controls.Add(this.caixadeEndereco);
            this.Controls.Add(this.caixadeNumero);
            this.Controls.Add(this.caixadeNome);
            this.Name = "FormCriarContas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Criar Contas";
            this.Load += new System.EventHandler(this.FormCriarContas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox caixadeNome;
        private System.Windows.Forms.TextBox caixadeNumero;
        private System.Windows.Forms.TextBox caixadeEndereco;
        private System.Windows.Forms.TextBox caixadeRg;
        private System.Windows.Forms.TextBox caixadeCpf;
        private System.Windows.Forms.TextBox caixadeSaldo;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label numero;
        private System.Windows.Forms.Label endereço;
        private System.Windows.Forms.Label rg;
        private System.Windows.Forms.Label cpf;
        private System.Windows.Forms.Label saldo;
        private System.Windows.Forms.Button criarESalvar;
    }
}