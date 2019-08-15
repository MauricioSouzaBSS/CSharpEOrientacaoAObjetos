using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioSomarPrimos
{
    public partial class Form1 : Form
    {
        int Primo1 = 2;
        int Primo2 = 3;
        int Primo3 = 7;
        long SomaPrimos;
        public Form1()
        {
            for(int indice = 2; indice < 30; indice ++)
            {
                if (indice % Primo1 == 0)
                {
                   
                }
                if (indice % Primo2 == 0)
                {
                    
                }
                if (indice % Primo3 == 0)
                {
                    indice++;
                    SomaPrimos = +SomaPrimos;
                }
                else
                {
                    indice++;
                }


            }
            MessageBox.Show("R: " + SomaPrimos);

            InitializeComponent();
        }
    }
}
