using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioSomaDePrimos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1Resultados_Click(object sender, EventArgs e)
        {
            int n, i, numero,
                num = 0;

            numero = Convert.ToInt32(textBox1.Text);
            n = 2;

            while (n <= numero) 
            {
                for (i = 2; n % i != 0; i++)
                    if (i == n)
                    {
                        listBox1.Items.Add(n);
                        if (++num % 10 == 0)
                            listBox1.Items.Add(n);
                    }
                    n++;
                     
            }
        }



        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
