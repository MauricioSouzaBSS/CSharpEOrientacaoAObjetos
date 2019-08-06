using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo5._1
{
    public partial class Form1 : Form
    {
        double valorInvestido = 1000.0;
        int i = 1;
        public Form1()
        {
            while (i <= 12)
            {
                valorInvestido = valorInvestido * 1.01;
                i += 1;
            }
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Valor Investido Agora é " + valorInvestido);
        }
    }
}
