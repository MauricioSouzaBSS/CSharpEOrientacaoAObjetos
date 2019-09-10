namespace CALCULADORA
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.StartingMileage = new System.Windows.Forms.Label();
            this.EndindMileage = new System.Windows.Forms.Label();
            this.AmountOwed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(114, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(201, 27);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(160, 26);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(201, 70);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(160, 26);
            this.numericUpDown2.TabIndex = 1;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.NumericUpDown2_ValueChanged);
            // 
            // StartingMileage
            // 
            this.StartingMileage.AutoSize = true;
            this.StartingMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartingMileage.Location = new System.Drawing.Point(41, 29);
            this.StartingMileage.Name = "StartingMileage";
            this.StartingMileage.Size = new System.Drawing.Size(140, 20);
            this.StartingMileage.TabIndex = 2;
            this.StartingMileage.Text = "Starting Mileage";
            this.StartingMileage.Click += new System.EventHandler(this.StartingMileage_Click);
            // 
            // EndindMileage
            // 
            this.EndindMileage.AutoSize = true;
            this.EndindMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndindMileage.Location = new System.Drawing.Point(41, 72);
            this.EndindMileage.Name = "EndindMileage";
            this.EndindMileage.Size = new System.Drawing.Size(132, 20);
            this.EndindMileage.TabIndex = 2;
            this.EndindMileage.Text = "Ending Mileage";
            this.EndindMileage.Click += new System.EventHandler(this.EndindMileage_Click);
            // 
            // AmountOwed
            // 
            this.AmountOwed.AutoSize = true;
            this.AmountOwed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountOwed.Location = new System.Drawing.Point(71, 132);
            this.AmountOwed.Name = "AmountOwed";
            this.AmountOwed.Size = new System.Drawing.Size(102, 18);
            this.AmountOwed.TabIndex = 2;
            this.AmountOwed.Text = "Amount Owed";
            this.AmountOwed.Click += new System.EventHandler(this.AmountOwed_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(179, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(384, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 48);
            this.button3.TabIndex = 4;
            this.button3.Text = "Display Miles";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 223);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AmountOwed);
            this.Controls.Add(this.EndindMileage);
            this.Controls.Add(this.StartingMileage);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Mileage Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label StartingMileage;
        private System.Windows.Forms.Label EndindMileage;
        private System.Windows.Forms.Label AmountOwed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
    }
}

