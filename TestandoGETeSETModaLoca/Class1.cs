using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestandoGETeSETModaLoca
{

    class Class1
    {
        private double numeroUm = 27;
        private int numeroDois = 34;

        public double getNumeroUm()  // METODO ACESSADOR GET EXECUTADO SEMPRE QUE A PROPRIEDADE É (LIDA)
        {
            return numeroUm;
        }
        public double setNumeroUm()  // METODO ACESSADOR SET CHAMADO SEMPRE QUE PROPRIEDADE É (DEFINIDA)
        {
            return numeroUm;
        }

        public int getNumeroDois()
        {
            return numeroDois;
        }
        public int setNumeroDois()
        {
            return numeroDois;
        }

    }
}
