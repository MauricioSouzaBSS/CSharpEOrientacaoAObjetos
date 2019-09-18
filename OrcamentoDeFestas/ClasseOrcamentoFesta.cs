using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcamentoDeFestas
{
    class ClasseOrcamentoFesta
    {
        const int CustoDeComidaPorPessoa = 25;
        public int QuantidadeDePessoas;
        public decimal CustoDeBebidasPorPessoa;
        public decimal CustoDeDecoracao = 0;

        public void DefinirOpcaoSaudavel(bool semAlcool)
        {
            if (semAlcool)
            {
                CustoDeBebidasPorPessoa = 5.00M;
            }
            else
            {
                CustoDeBebidasPorPessoa = 20.00M;
            }
        }
        public void CalcularCustoDeDecoracao(bool comDecoracao)
        {
            if (comDecoracao)
            {
                CustoDeDecoracao = (QuantidadeDePessoas * 15.00M) + 50M;
            }
            else
            {
                CustoDeDecoracao = (QuantidadeDePessoas * 7.50M) + 30M;
            }
        }
        public decimal CalcularCusto(bool semAlcool)
        {
            decimal custoTotal = CustoDeDecoracao + ((CustoDeBebidasPorPessoa + CustoDeComidaPorPessoa) * QuantidadeDePessoas);

            if (semAlcool)
            {
                return custoTotal * .95M; 
            }
            else
            {
                return custoTotal;
            }
        }
    }
}
