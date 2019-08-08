using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios6._7._2
{
    public class Conta
    {
        // numero, titular e saldo sao atributos do objeto
        public int numero;
        public string titular;
        public double saldo;


        public void Saca(double valorSaque)
        {
            if (saldo >= valorSaque)
            {
                saldo -= valorSaque;
            }
        }
    }

}
