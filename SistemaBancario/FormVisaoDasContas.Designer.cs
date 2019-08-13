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
            this.ListadeContas = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ListadeContas
            // 
            this.ListadeContas.Location = new System.Drawing.Point(12, 12);
            this.ListadeContas.Name = "ListadeContas";
            this.ListadeContas.Size = new System.Drawing.Size(776, 426);
            this.ListadeContas.TabIndex = 0;
            this.ListadeContas.UseCompatibleStateImageBehavior = false;
            // 
            // VisaoDasContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListadeContas);
            this.Name = "VisaoDasContas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lista de Contas";
            this.Load += new System.EventHandler(this.VisaoDasContas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListadeContas;
    }
}