using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            int limiteSequencia;
            limiteSequencia = Convert.ToInt32(textBoxInputUsuario.Text);
            int i, f1 = 1, f2 = 1, f3 = 0;
            listBoxItemsFibonacci.Items.Add(f1);
            listBoxItemsFibonacci.Items.Add(f2);
            for (i = 3; i <= limiteSequencia; i++)
            {
                f3 = f1 + f2;

                listBoxItemsFibonacci.Items.Add(f3);

                f1 = f2;
                f2 = f3;
            }
            textBoxSaida.Text = listBoxItemsFibonacci.Items.Count.ToString();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            listBoxItemsFibonacci.Items.Clear();
        }
    }

}

