using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo5      // Introdução ao for !
{
    public partial class Form1 : Form
    {
        double valorInvestido = 100.0;
        public Form1()
        {
            for (int i = 1; i<= 12; i += 1)
            {
                valorInvestido = valorInvestido * 1.1;
            }
           
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Valor investido agora é: " + valorInvestido);
        }
    }
}
