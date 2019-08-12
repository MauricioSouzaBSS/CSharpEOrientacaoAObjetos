using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBancario
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
            Conta c = new Conta();
            c.numero = 1;
            c.titular = "Nova Conta";
            //c.saldo = 100.10;
            //c.Saca(25.0);

            if (c.Saca(100.0))
            {
                MessageBox.Show("Saque realizado com Sucesso" + "\n\n"  + "Saldo Restante" + c.saldo);
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }
        }
    }
}
