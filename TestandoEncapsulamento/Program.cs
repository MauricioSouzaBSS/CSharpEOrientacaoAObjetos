using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            // Titulo do display da calculadora console.
            Console.WriteLine("============================================================================================");
            Console.WriteLine("\t\t\t\t Calculadora Console. \r");
            Console.WriteLine("============================================================================================\n");

            while (!endApp)
            {
                
                string varStringNumUm = "";
                string varStringNumDois = "";
                double varDoubleResultado = 0;

                double varNumUmConvertido;
                double varNumDoisConvertido;

                Console.Write("Digite um Número e Aperte Enter: ");
                varStringNumUm = Console.ReadLine();

                while (!double.TryParse(varStringNumUm, out varNumUmConvertido))      //TryParse para converter
                {
                    Console.Write("Esta Entrada não é Válida.Por favor insira um valor inteiro \n");
                    varStringNumDois = Console.ReadLine();
                }

                Console.Write("Digite o Segundo e Aperte Enter: ");
                varStringNumDois = Console.ReadLine();

                Console.WriteLine("");

                while (!double.TryParse(varStringNumDois, out varNumDoisConvertido))      //TryParse para converter
                {
                    Console.Write("Esta entrada não é válida. Por favor insira um valor inteiro \n");
                    varStringNumDois = Console.ReadLine();

                    Console.Write("Aperte 'n' e Enter para fechar o aplicativo ou pressione qualquer outra tecla e Enter para Continuar: ");
                    if (Console.ReadLine() == "n") endApp = true;

                    Console.WriteLine("\n");
                }
                Console.WriteLine("============================================================================================");
                Console.WriteLine("\t\t\t Escolha um operador da lista a seguir:");
                Console.WriteLine("============================================================================================");

                Console.WriteLine("");

                Console.WriteLine("\t +  Adicionar");
                Console.WriteLine("\t -  Subtrair");
                Console.WriteLine("\t *  Multiplicar");
                Console.WriteLine("\t /  Dividir");

                Console.WriteLine("");

                Console.WriteLine("============================================================================================");
                Console.Write("\t\t\t Digite sua Opção Matematica e Aperte Enter ! \n");
                Console.WriteLine("============================================================================================");
                
                string op = Console.ReadLine();
                try
                {
                    varDoubleResultado = Calculator.DoOperation(varNumUmConvertido, varNumDoisConvertido, op);
                    if (double.IsNaN(varDoubleResultado))
                    {
                       
                        Console.WriteLine("\t Esta operação apresentara um erro Matemático.\n");
                    }
                    else Console.WriteLine("\t Seu Resultado: {0:0.##}\n", varDoubleResultado);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ocorreu uma exceção ao tentar fazer as contas.\n - Detalhes: " + e.Message);
                }

                Console.WriteLine("============================================================================================\n");

                // Aguarde o usuário responder antes de fechar.
                Console.Write("Aperte 'n' e Enter para fechar o aplicativo ou pressione qualquer outra tecla e Enter para Continuar: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); 
            }
            return;
        }
    }
}