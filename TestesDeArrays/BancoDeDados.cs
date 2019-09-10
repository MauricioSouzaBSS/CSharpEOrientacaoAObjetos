using SistemaBancario.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDeArrays
{
    public class BancoDeDados
    {
        private static List<Cliente> dadosCliente = new List<Cliente>();
        public static void SalvarCliente (Cliente cliente)
        {
            dadosCliente.Add(cliente);

        }


      
            
    }
}
