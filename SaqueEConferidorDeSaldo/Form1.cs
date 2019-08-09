using System;
using System.Windows.Forms;

namespace SaqueEConferidorDeSaldo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Pessoa p1 = new Pessoa();
            p1.nome = "Mauricio";
            p1.sobreNome = "Souza";
            p1.pe = 40;
            p1.idade = 28;
            p1.altura = 1.78;

            Pessoa p2 = new Pessoa();
            p2.nome = "Arthur";
            p2.sobreNome = "Pinheiro";
            p2.pe = 40;
            p2.idade = 23;
            p2.altura = 1.65;

            // c.numero = 1;
            // c.saldo = 100;
            MessageBox.Show(p1.GetInformacoesPessoa()
              + "\n\n\n" + "Seguinte: " + "\n\n" + p2.GetInformacoesPessoa());
         //   InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
       
        private void Button1_Click(object sender, EventArgs e)
        {
        }
    }
}
