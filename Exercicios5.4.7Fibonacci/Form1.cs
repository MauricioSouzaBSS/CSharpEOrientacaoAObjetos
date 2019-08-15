using System;
using System.Windows.Forms;

namespace Exercicios5._4._7Fibonacci
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            long limiteSequencia;
            limiteSequencia = Convert.ToInt32(textBoxInputUsuario.Text);
            long indice;
            long pares = 0;
            long f1 = 1;
            long f2 = 1;
            long f3 = 0;

            listBoxItemsFibonacci.Items.Add(f1);
            listBoxItemsFibonacci.Items.Add(f2);
            for (indice = 3; indice <= limiteSequencia; indice ++)
            {

                f3 = f1 + f2;
                if (f3 % 2 == 0 && f2 % 2 == 0)
                {
                    pares =+ f3;
                }
                pares = f1;
                listBoxItemsFibonacci.Items.Add(f3);
             
                f1 = f2;
                f2 = f3;
                if (f3 % 2 == 0)
                {
                    pares = +f3;
                }


            }
            textBoxSaida.Text = listBoxItemsFibonacci.Items.Count.ToString();
            MessageBox.Show("R:" + pares);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            listBoxItemsFibonacci.Items.Clear();
            
        }
        
    }

}

