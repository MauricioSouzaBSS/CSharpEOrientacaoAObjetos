namespace SistemaBancario
{
    partial class FormMENUINICIAL
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
            this.buttonAcessarSistemaBancario = new System.Windows.Forms.Button();
            this.MensagemInicial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAcessarSistemaBancario
            // 
            this.buttonAcessarSistemaBancario.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAcessarSistemaBancario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcessarSistemaBancario.Location = new System.Drawing.Point(55, 70);
            this.buttonAcessarSistemaBancario.Name = "buttonAcessarSistemaBancario";
            this.buttonAcessarSistemaBancario.Size = new System.Drawing.Size(166, 39);
            this.buttonAcessarSistemaBancario.TabIndex = 0;
            this.buttonAcessarSistemaBancario.Text = "Entrar.";
            this.buttonAcessarSistemaBancario.UseVisualStyleBackColor = true;
            this.buttonAcessarSistemaBancario.Click += new System.EventHandler(this.ButtonAcessarSistemaBancario_Click);
            // 
            // MensagemInicial
            // 
            this.MensagemInicial.AutoSize = true;
            this.MensagemInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MensagemInicial.Location = new System.Drawing.Point(94, 9);
            this.MensagemInicial.Name = "MensagemInicial";
            this.MensagemInicial.Size = new System.Drawing.Size(89, 24);
            this.MensagemInicial.TabIndex = 1;
            this.MensagemInicial.Text = "Sistema.";
            this.MensagemInicial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormMENUINICIAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 121);
            this.Controls.Add(this.MensagemInicial);
            this.Controls.Add(this.buttonAcessarSistemaBancario);
            this.Name = "FormMENUINICIAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema.";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAcessarSistemaBancario;
        private System.Windows.Forms.Label MensagemInicial;
    }
}

