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
    class Calcula
    {
        public string calculaNumeroPrimo(int n)
        {
            string resultado = n.ToString();
            {
                for (int i = 2; i < n; i++)
                {
                    int resto = n % i;
                    if (resto == 0)
                    {
                        resultado = n + " não é um número primo";
                        i = n + 1;
                    }
                    else
                    {
                        resultado = n + " é um número primo";
                    }
                }
            }

            {
                MessageBox.Show("Erro ao Verificar nº primo");
            }
            MessageBox.Show(resultado);
            
            return resultado;
        }
    }
}
