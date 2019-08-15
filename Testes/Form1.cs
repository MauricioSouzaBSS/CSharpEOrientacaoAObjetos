using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testes
{
    public partial class Form1 : Form
    {
        int indice = 0;
     

        public Form1()
        {

            int quantidadePares = 0;
            int quantidadeImpares = 0;
            int somaPares = 0;
            int somaImpares = 0;

            for (indice = 1; indice < 20; indice += 1)
            {
                if (indice % 2 == 0)
                {
                    somaPares = somaPares + indice;
                    quantidadePares++;
                    MessageBox.Show("Pares: " + quantidadePares + "\n" + "Soma Pares: " + somaPares + "\n" +"Indice: " + indice);
                }
                else
                {
                    somaImpares = somaImpares + indice;
                    quantidadeImpares++;
                    MessageBox.Show("Impares: " + quantidadeImpares + "\n" + "Soma Impares: " + somaImpares + "\n" + "Indice: " + indice);
                }
               
            }
            MessageBox.Show("Resultados: " + "\n" +
                    "Quantidade Pares: " + quantidadePares + "\n" +
                    "Quantidade Impares: " + quantidadeImpares + "\n" +
                    "Soma de Todos Pares: " + somaPares + "\n" +
                    "Soma de Todos Impares: " + somaImpares + "\n" +
                    "Indice Total loop: " + indice);

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
