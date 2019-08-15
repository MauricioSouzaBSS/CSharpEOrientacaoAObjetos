namespace Testes
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
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.label1ConsumoDeCombustivel = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1InsiraAMedia = new System.Windows.Forms.Label();
            this.label1PrecoDoLitro = new System.Windows.Forms.Label();
            this.label2KilometrosaFazer = new System.Windows.Forms.Label();
            this.labelLitrosAbastecidos = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.labelValorAbastecido = new System.Windows.Forms.Label();
            this.labelResultados = new System.Windows.Forms.Label();
            this.buttonLimparCaixas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcular.Location = new System.Drawing.Point(189, 314);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(155, 51);
            this.buttonCalcular.TabIndex = 5;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.ButtonCalcular_Click);
            // 
            // label1ConsumoDeCombustivel
            // 
            this.label1ConsumoDeCombustivel.AutoSize = true;
            this.label1ConsumoDeCombustivel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1ConsumoDeCombustivel.Location = new System.Drawing.Point(75, 19);
            this.label1ConsumoDeCombustivel.Name = "label1ConsumoDeCombustivel";
            this.label1ConsumoDeCombustivel.Size = new System.Drawing.Size(209, 44);
            this.label1ConsumoDeCombustivel.TabIndex = 2;
            this.label1ConsumoDeCombustivel.Text = "Calcular Consumo de \r\nCombustível";
            this.label1ConsumoDeCombustivel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1ConsumoDeCombustivel.Click += new System.EventHandler(this.Label1ConsumoDeCombustivel_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(187, 98);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(144, 20);
            this.TextBox1.TabIndex = 1;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(187, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(186, 241);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(144, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(187, 267);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(144, 20);
            this.textBox5.TabIndex = 8;
            this.textBox5.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            // 
            // label1InsiraAMedia
            // 
            this.label1InsiraAMedia.AutoSize = true;
            this.label1InsiraAMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1InsiraAMedia.Location = new System.Drawing.Point(29, 102);
            this.label1InsiraAMedia.Name = "label1InsiraAMedia";
            this.label1InsiraAMedia.Size = new System.Drawing.Size(110, 16);
            this.label1InsiraAMedia.TabIndex = 4;
            this.label1InsiraAMedia.Text = "Insira a Média:";
            this.label1InsiraAMedia.Click += new System.EventHandler(this.Label1InsiraAMedia_Click);
            // 
            // label1PrecoDoLitro
            // 
            this.label1PrecoDoLitro.AutoSize = true;
            this.label1PrecoDoLitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1PrecoDoLitro.Location = new System.Drawing.Point(29, 128);
            this.label1PrecoDoLitro.Name = "label1PrecoDoLitro";
            this.label1PrecoDoLitro.Size = new System.Drawing.Size(111, 16);
            this.label1PrecoDoLitro.TabIndex = 4;
            this.label1PrecoDoLitro.Text = "Preço Do Litro:";
            this.label1PrecoDoLitro.Click += new System.EventHandler(this.Label1PrecoDoLitro_Click);
            // 
            // label2KilometrosaFazer
            // 
            this.label2KilometrosaFazer.AutoSize = true;
            this.label2KilometrosaFazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2KilometrosaFazer.Location = new System.Drawing.Point(28, 245);
            this.label2KilometrosaFazer.Name = "label2KilometrosaFazer";
            this.label2KilometrosaFazer.Size = new System.Drawing.Size(141, 16);
            this.label2KilometrosaFazer.TabIndex = 4;
            this.label2KilometrosaFazer.Text = "kilometros A Fazer:";
            this.label2KilometrosaFazer.Click += new System.EventHandler(this.Label2KilometrosaFazer_Click);
            // 
            // labelLitrosAbastecidos
            // 
            this.labelLitrosAbastecidos.AutoSize = true;
            this.labelLitrosAbastecidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLitrosAbastecidos.Location = new System.Drawing.Point(28, 271);
            this.labelLitrosAbastecidos.Name = "labelLitrosAbastecidos";
            this.labelLitrosAbastecidos.Size = new System.Drawing.Size(141, 16);
            this.labelLitrosAbastecidos.TabIndex = 4;
            this.labelLitrosAbastecidos.Text = "Litros Abastecidos:";
            this.labelLitrosAbastecidos.Click += new System.EventHandler(this.LabelLitrosAbastecidos_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(187, 151);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(144, 20);
            this.textBox8.TabIndex = 3;
            this.textBox8.TextChanged += new System.EventHandler(this.TextBox8_TextChanged);
            // 
            // labelValorAbastecido
            // 
            this.labelValorAbastecido.AutoSize = true;
            this.labelValorAbastecido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorAbastecido.Location = new System.Drawing.Point(29, 155);
            this.labelValorAbastecido.Name = "labelValorAbastecido";
            this.labelValorAbastecido.Size = new System.Drawing.Size(132, 16);
            this.labelValorAbastecido.TabIndex = 4;
            this.labelValorAbastecido.Text = "Valor Abastecido:";
            this.labelValorAbastecido.Click += new System.EventHandler(this.LabelValorAbastecido_Click);
            // 
            // labelResultados
            // 
            this.labelResultados.AutoSize = true;
            this.labelResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultados.Location = new System.Drawing.Point(193, 213);
            this.labelResultados.Name = "labelResultados";
            this.labelResultados.Size = new System.Drawing.Size(137, 25);
            this.labelResultados.TabIndex = 5;
            this.labelResultados.Text = "Resultados:";
            this.labelResultados.Click += new System.EventHandler(this.LabelResultados_Click);
            // 
            // buttonLimparCaixas
            // 
            this.buttonLimparCaixas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimparCaixas.Location = new System.Drawing.Point(9, 314);
            this.buttonLimparCaixas.Name = "buttonLimparCaixas";
            this.buttonLimparCaixas.Size = new System.Drawing.Size(160, 51);
            this.buttonLimparCaixas.TabIndex = 11;
            this.buttonLimparCaixas.Text = "Limpar Caixas";
            this.buttonLimparCaixas.UseVisualStyleBackColor = true;
            this.buttonLimparCaixas.Click += new System.EventHandler(this.ButtonLimparCaixas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 375);
            this.Controls.Add(this.buttonLimparCaixas);
            this.Controls.Add(this.labelResultados);
            this.Controls.Add(this.labelLitrosAbastecidos);
            this.Controls.Add(this.labelValorAbastecido);
            this.Controls.Add(this.label2KilometrosaFazer);
            this.Controls.Add(this.label1PrecoDoLitro);
            this.Controls.Add(this.label1InsiraAMedia);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.label1ConsumoDeCombustivel);
            this.Controls.Add(this.buttonCalcular);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular Consumo De Combustível.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label label1ConsumoDeCombustivel;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1InsiraAMedia;
        private System.Windows.Forms.Label label1PrecoDoLitro;
        private System.Windows.Forms.Label label2KilometrosaFazer;
        private System.Windows.Forms.Label labelLitrosAbastecidos;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label labelValorAbastecido;
        private System.Windows.Forms.Label labelResultados;
        private System.Windows.Forms.Button buttonLimparCaixas;
    }
}

