using System;

namespace TesteDeEncapsulamentos
{
    class Teste
    {

        private double numUm;           //  VARIAVEIS DECLARADAS COMO LOCAL PRIVADO 
        private double numDois;
        private double total;

        //public double getNumUm()        // ACESSADOR GET: METODO EXECUTADO SEMPRE QUE A PROPRIEDADE  getNumUm É LIDA
        //                                // POSSUI UM VALOR DE RETORNO QUE CORRESPONDE AO TIPO DA VARIAVEL
        //    {                           // NESTE CASO ELE RETORNA O VALOR DA PROPRIEDADE PRIVADA getNumUm
        //        return numUm;
        //    }
        
        //public double NumUm                         
        //{
        //    get { return numUm; }
        //    set { numUm = value; }
        //}

        //public double getNumDois()        UMA DAS MANEIRAS DE USAR O GET E O SET    (ESTUDAR AS MANEIRAS !!!!! )
        //{
        //    return numDois;
        //}   
        
        //public void setNumDois(double numDois)
        //{
        //    this.numDois = numDois;
        //}
 
        // ==================================================================================================================================== //
        public void setNumUm(double numUm)  
        {                                   // ACESSADOR SET: CHAMADO SEMPRE QUE A PROPRIEDADE getNumUm É DEFINIDA
            this.numUm = numUm;             // 
        }

        public double getNumDois()
        {
            return numDois;
        }
        public void setNumDois(double numDois)
        {
            this.numDois = numDois;
        }
        public double getTotal()
        {
            return total;
        }
        public void Multiplicar()
        {
            this.total = this.numUm * this.numDois;
        }
        public void  Exibir()
        {
            Console.WriteLine("O total é de: " + this.total);
        }

            
            
            


    }
}
