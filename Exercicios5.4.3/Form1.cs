using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios5._4._3
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("multiplo atual: " + Convert.ToString(i));
                }
            }
            
            InitializeComponent();
        }

        private string MultiplosDeTres()
        {
            string resultado = String.Empty;

            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("multiplo atual: " + Convert.ToString(i));
                    resultado += "multiplo atual: " + Convert.ToString(i);
                    resultado += "\n";
                }
            }
            return resultado;
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(MultiplosDeTres());
       }
    }
}
