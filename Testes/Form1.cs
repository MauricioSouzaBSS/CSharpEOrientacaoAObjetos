using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testes
{
    public partial class Form1 : Form
    {

        double Media;
        double Litros;
        double GastoEmLitros;
        double LitroVale;
        double KmsAFazer;
        double GastoSemana;
  

        public Form1()
        {
            InitializeComponent();   
        }

        public void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Label1ConsumoDeCombustivel_Click(object sender, EventArgs e)
        {

        }

        private void LabelGastoNoMes_Click(object sender, EventArgs e)
        {

        }

        private void LabelGastosnaSemana_Click(object sender, EventArgs e)
        {

        }

        private void LabelLitrosAbastecidos_Click(object sender, EventArgs e)
        {

        }

        private void Label3GastoEmLitros_Click(object sender, EventArgs e)
        {

        }

        private void LabelValorAbastecido_Click(object sender, EventArgs e)
        {

        }

        private void LabelLitrosAbastecidos2_Click(object sender, EventArgs e)
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

        public void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        public void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        public void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        public void TextBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        public void TextBox4_TextChanged(object sender, EventArgs e)
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

        public void LabelResultados_Click(object sender, EventArgs e)
        {

        }

        public void ButtonCalcular_Click(object sender, EventArgs e)
        {


            Media = Convert.ToDouble(TextBox1.Text);
            LitroVale = Convert.ToDouble(textBox2.Text);
            GastoEmLitros = Convert.ToDouble(textBox8.Text);

            Litros = GastoEmLitros / LitroVale;
            KmsAFazer = Litros * Media;
            GastoSemana = GastoEmLitros / LitroVale * 5;
          
            
            textBox3.Text = KmsAFazer.ToString("F");
            textBox5.Text = Litros.ToString("F");

        }

        private void ButtonLimparCaixas_Click(object sender, EventArgs e)
        {
            TextBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox8.Clear();
         
        }
    }
}
