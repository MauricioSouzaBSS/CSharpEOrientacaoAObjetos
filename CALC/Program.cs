using System;

namespace CALC
{
    class Program2
    {
        static void Main(string[] args)         
        {
            int retorno = CalcularSoma();

            Console.WriteLine(CalcularSoma());

            MostrarMensagemNaTela();

            Tabuada(9);
            Tabuada(99);
            Tabuada(4);

            Console.Read();
        }

        public static int CalcularSoma()
        {
            int a = 1;
            int b = 2;
            int c = a + b;
            return c;
        }
        public static void MostrarMensagemNaTela()    // FUNÇÃO
        {
            Console.WriteLine("");
        }
        public static void Tabuada(int numero)        // FUNÇÃO
        {
            Console.WriteLine("===============================================================");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero * i));
            }
            Console.WriteLine("===============================================================");
        }
    }
}