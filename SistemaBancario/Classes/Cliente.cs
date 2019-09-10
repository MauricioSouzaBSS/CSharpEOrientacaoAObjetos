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
        public string Numero { get; set; }
        public string Endereco { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }

        private Conta contaBancaria;
        public void AdicionarConta(double saldo)
        {
            Conta conta = new Conta();
            conta.saldo = saldo;
            contaBancaria = conta;
        }
    }
}
