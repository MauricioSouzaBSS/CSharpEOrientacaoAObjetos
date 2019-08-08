namespace Exercicios5._4._7Fibonacci
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInputUsuario = new System.Windows.Forms.TextBox();
            this.listBoxItemsFibonacci = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSaida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "Executar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(83, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número de Sequências.";
            // 
            // textBox1
            // 
            this.textBoxInputUsuario.Location = new System.Drawing.Point(210, 63);
            this.textBoxInputUsuario.Name = "textBox1";
            this.textBoxInputUsuario.Size = new System.Drawing.Size(142, 20);
            this.textBoxInputUsuario.TabIndex = 2;
            this.textBoxInputUsuario.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBoxItemsFibonacci.FormattingEnabled = true;
            this.listBoxItemsFibonacci.Location = new System.Drawing.Point(82, 102);
            this.listBoxItemsFibonacci.Name = "listBox1";
            this.listBoxItemsFibonacci.Size = new System.Drawing.Size(270, 355);
            this.listBoxItemsFibonacci.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(154, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contador";
            // 
            // textBox2
            // 
            this.textBoxSaida.Location = new System.Drawing.Point(210, 472);
            this.textBoxSaida.Name = "textBox2";
            this.textBoxSaida.Size = new System.Drawing.Size(142, 20);
            this.textBoxSaida.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(409, 40);
            this.label3.TabIndex = 6;
            this.label3.Text = "Executar Sequencia de Fibonacci.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(433, 520);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSaida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxItemsFibonacci);
            this.Controls.Add(this.textBoxInputUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInputUsuario;
        private System.Windows.Forms.ListBox listBoxItemsFibonacci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSaida;
        private System.Windows.Forms.Label label3;
    }
}

