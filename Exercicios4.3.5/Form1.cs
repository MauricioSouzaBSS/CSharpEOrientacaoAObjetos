using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios4._3._5      
{
    public partial class Form1 : Form
    {
        double valorDaNotaFiscal = 0;
        public Form1()
        {
            valorDaNotaFiscal = 4200.000;
            InitializeComponent();
           AtualizarValorDaNotaFiscal();
        }

        public void AtualizarValorDaNotaFiscal()
        {
            if (valorDaNotaFiscal <= 999)
            {
                valorDaNotaFiscal += valorDaNotaFiscal * 2 /100;
            }
            if (valorDaNotaFiscal > 1000 && valorDaNotaFiscal < 3000)
            {
                valorDaNotaFiscal += valorDaNotaFiscal * 2.5 / 100;
            }
            if (valorDaNotaFiscal > 3000 && valorDaNotaFiscal < 6999)
            {
                valorDaNotaFiscal += valorDaNotaFiscal * 2.8 / 100;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Total " + (valorDaNotaFiscal));
        }
    }
}
