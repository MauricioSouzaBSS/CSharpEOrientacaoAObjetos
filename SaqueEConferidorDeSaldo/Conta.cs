using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaqueEConferidorDeSaldo
{
    public class Conta
    {
        public int numero;
        public String titular;
        public double saldo;
        

        /* ESTE É O CONSTRUTOR DA CLASSE 'CONTA'
        ELE SERVE PARA INICIALIZAR A CLASSE (a inicialização de uma classe
        acontece quando eu fizer o seguinte código: new NomeClasse())
        */
        public Conta()      // CONSTRUTOR
        {
            saldo = 10045;
            titular = "ZÉ";
        }


        public bool Saca(double valor)
            
        {
           if (this.saldo >= valor)
           {
                this.saldo -= valor;
                return true;
           }
            return false;
        }

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }

        public void Transfere(double valor, Conta destino)
        {
            destino.Deposita(valor);
        }
    }

}
