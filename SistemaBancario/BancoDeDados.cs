using SistemaBancario.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    public static class BancoDeDados   // classe e objeto
    {
        private static List<Cliente> dadosCliente = new List<Cliente>();   // LISTA
        public static void SalvarCliente(Cliente cliente)
        {
            dadosCliente.Add(cliente);

        }

        public static void ExcluirCliente(Cliente cliente)   // DELETAR CLIENTE
        { 

            dadosCliente.Remove(cliente);

        }
    }
}
