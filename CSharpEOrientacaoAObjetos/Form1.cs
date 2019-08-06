using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEOrientacaoAObjetos
{
    public partial class Form1 : Form
    {
        double taxa;
        double saldo = 5000000.000;
        public Form1()
        {
            InitializeComponent();

            if (saldo < 1000)
            {
                taxa = 0.01;
            }
            else if (saldo <= 5000)
            {
                taxa = 0.05;
            }
            else
            {
                taxa = 0.1;
            }
                              // divisao dos if
            if (saldo < 500)
            {
                MessageBox.Show("Você esta no negativo!");
            }
            else if (saldo <= 50000.0)
            {
                MessageBox.Show("Você é bom um Cliente!");
            }
            else
            {
                MessageBox.Show("Você é um Milionario!");
            }
            
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
    }
}
