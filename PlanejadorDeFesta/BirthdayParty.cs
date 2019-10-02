using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanejadorDeFesta
{
    class BirthdayParty
    {

        public  const int CustoDeComidaPorPessoa = 25;

        public decimal CustoDeDecoracao = 0;
        private bool decoracaoFancy;
        public int TamanhoDoBolo;
    


        private void CalcularTamanhoDoBolo()
        {

        }
        
        public BirthdayParty(int numeroDePessoas, bool decoracaoFancy, string EscritaDoBolo)
        {

            this.numeroDePessoas = numeroDePessoas;
            this.decoracaoFancy = decoracaoFancy;
            CalcularTamanhoDoBolo();

            this.EscritaDoBolo = EscritaDoBolo;
            CalcularCustoDeDecoracao(decoracaoFancy);
        }
        public decimal CalcularCusto()
        {
            decimal CustoTotal = CustoDeDecoracao + (CustoDeComidaPorPessoa * numeroDePessoas);
            decimal CustoDoBolo;
            if (TamanhoDoBolo == 8)
                CustoDoBolo = 40M + EscritaDoBolo.Length * .25M;
            else
                CustoDoBolo = 75M + EscritaDoBolo.Length * .25M;
            return CustoTotal + CustoDoBolo;
        }
        private int numeroDePessoas;
        public int numeroDePessoas
        {
            get
            {
                return numeroDePessoas;
            }
            set
            {
                numeroDePessoas = value;
                CalcularCustoDeDecoracao(decoracaoFancy);
                CalcularTamanhoDoBolo();
                this.EscritaDoBolo = EscritaDoBolo;
            }
        }
        public void CalcularCustoDeDecoracao(bool fancy) {
            decoracaoFancy = fancy;
            if (fancy)
                CustoDeDecoracao = (numeroDePessoas * 15.00M) + 50M;
            else
                CustoDeDecoracao = (numeroDePessoas * 7.50M) + 30M;
        }

       
            
    }
}
