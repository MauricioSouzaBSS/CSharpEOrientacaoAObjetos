using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    
    public class Conta
    {
      
         
        public int numero;
        public string titular;
        public double saldo = 0.10;

        

        public Conta ()
        {
            saldo = 120.10;
            titular = "";
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
    }

    
}
