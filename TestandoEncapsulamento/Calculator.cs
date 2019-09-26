using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator

    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value is "not-a-number" which we use if an operation, such as division, could result in an error.
                                        //// Declare as Variaveis com valores zero.
                                        //double num1 = 0; double num2 = 0;


            // Use o switch para escolher uma opção.
            switch (op)
            {
                case "+":
                    Console.WriteLine($"Resultado: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine($"Resultado: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine($"Resultado: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "/":
                    // Peça ao usuário para inserir um divisor diferente de zero até que ele faça isso.
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }

                    break;
                //
                default:
                    break;
            }
            return result;
        }
    }
}
