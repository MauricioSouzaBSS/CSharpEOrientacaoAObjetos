using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testesdeRepeticao
{
    public partial class Form1 : Form
    {
        double saldo = 10.0;
        
        public Form1()
            
        {
            
            double valorInvestido = 10.0;
            saldo = 0;
            do
            {
                valorInvestido = valorInvestido * 2;
            }
            while (this.saldo < 21);
          
;

            MessageBox.Show("" + valorInvestido);
            
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
