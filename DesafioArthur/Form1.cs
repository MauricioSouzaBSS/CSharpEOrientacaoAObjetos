using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioArthur
{
    public partial class Form1 : Form
    {
        long limite = 4000000;
        long indice;
        long pares = 0;
        long numeroAnterior = 0;
        long numeroAtual = 1;
        long numeroProximo = 1;

        public Form1()
        {
            for (indice = 0; indice < limite && numeroAtual < limite *2; indice++ )
            {

                numeroAnterior = numeroAtual + numeroProximo;
                numeroAtual = numeroProximo;
                numeroProximo = numeroAnterior;

                if (numeroAtual  % 2 != 0)
                {
                    pares += numeroAtual;
                }

            }
            MessageBox.Show("R: " + pares);

            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
