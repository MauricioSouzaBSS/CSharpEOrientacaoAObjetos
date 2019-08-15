using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SistemaBancario.Classes
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Numero { get; set; }
        public int Endereço { get; set; }
        public int RG { get; set; }
        public double CPF { get; set; }

        private Conta contaBancaria;
        public void AdicionarConta(double saldo)
        {
            Conta conta = new Conta();
            conta.saldo = saldo;
            contaBancaria = conta;
        }
    }
}
