using System;
using System.Windows.Forms;

namespace Testes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();   
        }

        public void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void LabelLitrosAbastecidos_Click(object sender, EventArgs e)
        {
            
        }

        private void LabelValorAbastecido_Click(object sender, EventArgs e)
        {
            
        }

        private void Label2KilometrosaFazer_Click(object sender, EventArgs e)
        {
            
        }

        private void Label1PrecoDoLitro_Click(object sender, EventArgs e)
        {
            
        }

        private void Label1InsiraAMedia_Click(object sender, EventArgs e)
        {
            
        }

        public void TextBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void TextBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void TextBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        double media;
        double litros;
        double gastoEmLitros;
        double litroVale;
        double kmsAFazer;

        public void ButtonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                media = Convert.ToDouble(TextBox1.Text);
                litroVale = Convert.ToDouble(textBox2.Text);
                gastoEmLitros = Convert.ToDouble(textBox8.Text);

                litros = gastoEmLitros / litroVale;
                kmsAFazer = litros * media;

                textBox3.Text = kmsAFazer.ToString("F");
                textBox5.Text = litros.ToString("F");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro! Campo em Branco ou Letras nos Campos! ");
                LimparTextBox();
            }
        }

        private void LimparTextBox()
        {
            TextBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox8.Clear();
         
        }

    }
}
