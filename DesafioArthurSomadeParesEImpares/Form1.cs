using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioArthurSomadeParesEImpares
{
    public partial class Form1 : Form
    {
        int indice;    //contador

        public Form1()
        {
            indice = 0;
            int somaPares = 0;
            int somaImpares = 0;
            int quantidadePares = 0;
            int quantidadeImpares = 0;
          

            for (indice = 0; indice < 20; indice ++)    // contador de volta
            {
                
                if (indice % 2 == 0)                    // se o número atual for par, então vamos somar
                {
                    somaPares = somaPares + indice;
                    quantidadePares++;
                }
                else                                    // caso contrário
                {
                    somaImpares = somaImpares + indice;
                    quantidadeImpares ++;
                }
            }

            MessageBox.Show("Resultados:" + "\n\n" +
                    "Pares: " + quantidadePares + "\n" +
                    "soma Pares: " + somaPares + "\n\n" +

                    "Impares: " + quantidadeImpares + "\n" +
                    "Soma Impares: " + somaImpares + "\n\n" +
                    "indice: " + indice);



            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
