using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaqueEConferidorDeSaldo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            double Saldo = 1200.0;
            double varValorSaque = 110.0;
            MessageBox.Show("Seu Saldo Atual é de : " + Saldo);
            MessageBox.Show("Deseja fazer um saque? ");
            if (Saldo >= varValorSaque)
            {
                MessageBox.Show("Pode Sacar !");
                Saldo = Saldo - varValorSaque;
                MessageBox.Show("Saque Realizado com Sucesso ! ");
                MessageBox.Show("seu saldo restante ficou em: " + Saldo);
            }
            else
            {
                MessageBox.Show("Não pode Sacar ! Pois seu Saldo é de: " + Saldo + " Reais." + " E Você quer Sacar: " + varValorSaque);
            }

            // InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }

    }
}
