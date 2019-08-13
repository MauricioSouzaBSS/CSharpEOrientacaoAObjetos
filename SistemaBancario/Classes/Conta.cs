using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{

    public class Conta
    {

        public string nome;
        public int numero;
        public int endereço;
        public int rg;
        public double cpf;
        public double saldo = 0.10;

        public Conta()
        {

            saldo = 0.10;

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
        public void Deposita (double valor)
        {
            this.saldo += valor;
        }
        public void transfere (double valor, Conta destino)
        {
            destino.Deposita(valor);
        }

        //public string GetInformacoesPessoa()
        //{
        //    return  " +  + "\n" + "Sobre Nome: " +  + "\n" + "Idade: " +  + "\n" + "Altura: " +  + "\n" + "Pé: " + ;
        //}
    }

    
}
