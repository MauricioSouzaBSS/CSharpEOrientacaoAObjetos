using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios5._4._2
{
    public partial class Form1 : Form // fazer somar de 1 ate 1000 
    {
        
        public Form1()
        {
            for (double i = 1; i <= 1000; i += i)
            {
             //   Console.WriteLine("valor: " + Convert.ToString(i));
            }
                
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            for (double i = 1; i <= 1000; i += i)
                MessageBox.Show("valor" + i);
        }
    }
}
