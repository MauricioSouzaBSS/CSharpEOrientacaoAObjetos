using System;

namespace TesteDeEncapsulamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1;  // QUANDO NAO TEM NADA DECLARADO ANTES DO TIPO
            double n2;  // DA VARIAVEL, O C# JA INDENTIFICA COMO LOCAL PRIVADO !
            bool endApp = false;

            while(!endApp)
            {
                try
                {

                    Console.WriteLine("Digite um número: ");
                    n1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Digite outro número: ");
                    n2 = Convert.ToDouble(Console.ReadLine());

                    Teste te = new Teste();
                    te.setNumUm(n1);
                    te.setNumDois(n2);
                    te.Multiplicar();
                    te.Exibir();

                    Console.ReadKey();

                }

                catch (Exception e)
                {
                    Console.WriteLine("[ERRO]- " + " Você digitou um valor incorreto. ");
                
                }
                Console.Write("Aperte 'n' e Enter para fechar o aplicativo ou pressione qualquer outra tecla e Enter para Continuar: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");
            }

        }
    }
}
    

            
                
                
        

        
        

