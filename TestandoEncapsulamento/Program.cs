using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            //
            // Titulo do display da calculadora console.
            Console.WriteLine("Calculadora Console em C Sharp.\r");
            Console.WriteLine("----------------------------------------------------------------------------------------------\n");

            while (!endApp)
            {
                //
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                //

                Console.Write("Digite um Número e Aparte Enter: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                double cleanNum2 = 0;
                //
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Esta entrada não é válida.Por favor insira um valor inteiro \n");
                    numInput2 = Console.ReadLine();
                }
                // Ask the user to choose an operator.
                Console.WriteLine("Choose an operator from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("Your option? ");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }

                Console.WriteLine("--------------------------------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); // Friendly linespacing.
            }
            return;
        }
    }
}
        