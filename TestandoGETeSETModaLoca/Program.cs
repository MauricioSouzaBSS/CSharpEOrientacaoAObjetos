using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestandoGETeSETModaLoca
{
    class Program
    {  
       static double recebendoGetNumeroUm;
       static double recebendoGetNumeroDois;

        static void Main(string[] args)
        {

           Class1 class1 = new Class1();

            

            recebendoGetNumeroUm = class1.getNumeroUm();
            Console.WriteLine(recebendoGetNumeroUm);


            recebendoGetNumeroDois = class1.getNumeroDois();
            Console.WriteLine(recebendoGetNumeroDois);

            // Console.WriteLine(string.Format("{0}", recebendoGetNumeroDois));



            Console.Read();

        }
    }
}
