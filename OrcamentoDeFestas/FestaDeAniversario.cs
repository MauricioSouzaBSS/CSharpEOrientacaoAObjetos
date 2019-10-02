using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace OrcamentoDeFestas
{
    class FestaDeAniversario
    {
        public const int CustoDeComidaPorPessoa = 25;

        public int QuantidadeDePessoas;
       // public decimal CustoDeBebidasPorPessoa;
        public decimal CustoDeDecoracao = 0;

        private bool decoracaoDaFancy;
        public int TamanhoDoBolo;
       

        public FestaDeAniversario(int numberOfPeople, bool decoracaoDaFancy, string EscritaDoBolo)
        {

            this.QuantidadeDePessoas = quantidadeDePessoas;
            this.decoracaoDaFancy = decoracaoDaFancy;

            CalcularTamanhoDoBolo();

            this.EscritaDoBolo = escritaDoBolo;

            CalcularCustoDeDecoracao(decoracaoDaFancy);
        }

        private void CalcularTamanhoDoBolo()
        {
            if (QuantidadeDePessoas <= 4)
                TamanhoDoBolo = 8;
            else
                TamanhoDoBolo = 16;
        }
        private string escritaDoBolo = "";
        public string EscritaDoBolo
        {
            get { return this.escritaDoBolo; }
            set
            {
                int maxLength;
                if (TamanhoDoBolo == 8)
                    maxLength = 16;
                else
                    maxLength = 40;
                if (value.Length > maxLength)
                {
                    MessageBox.Show("Too many letters for a " + TamanhoDoBolo + " inch cake");
                    if (maxLength > this.escritaDoBolo.Length)
                        maxLength = this.escritaDoBolo.Length;
                    this.escritaDoBolo = escritaDoBolo.Substring(0, maxLength);
                }
                else
                    this.escritaDoBolo = value;
            }
        }

        public decimal CalcularCusto()
        {
            decimal CustoTotal = CustoDeDecoracao + (CustoDeComidaPorPessoa * QuantidadeDePessoas);
            decimal CustoDoBolo;
            if (TamanhoDoBolo == 8)
                CustoDoBolo = 40M + EscritaDoBolo.Length * .25M;
            else
                CustoDoBolo = 75M + EscritaDoBolo.Length * .25M;
            return CustoTotal + CustoDoBolo;
        }

        private int quantidadeDePessoas;
        public int QuantidadeDePessoas
        {
            get
            {
                return quantidadeDePessoas; 
            }
            set
            {
                quantidadeDePessoas = value;
                CalcularCustoDaDecoracao(decoracaoDaFancy);
                CalcularTamanhoDoBolo();
                this.EscritaDoBolo = escritaDoBolo;
            }
        }
        public void CalcularCustoDaDecoracao (bool fancy)
        {
            decoracaoDaFancy = fancy;
            if (fancy)
                CustoDeDecoracao = (QuantidadeDePessoas * 15.00M) + 50M;
            else
                CustoDeDecoracao = (QuantidadeDePessoas * 7.50M) + 30M;
        }

    }
}
