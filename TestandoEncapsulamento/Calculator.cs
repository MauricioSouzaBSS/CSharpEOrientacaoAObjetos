using System;

namespace Calculator
{
    class Calculator

    {
        public static double DoOperation(double varDoubleNumUm, double varDoubleNumDois, string op)
        {
            double result = double.NaN; // O valor padrão é "não é um número" que usamos se uma 
                                        // operação, como divisão, puder resultar em um erro.
                                        // Declare as Variaveis com valores zero.
                                        // varDoubleNumUm double = 0; varDoubleNumDois double = 0;

            // Use o switch para escolher uma opção.
            switch (op)
            {
                case "+":
                    Console.WriteLine($"Resultado: {varDoubleNumUm} + {varDoubleNumDois} = " + (varDoubleNumUm + varDoubleNumDois));
                    break;
                case "-":
                    Console.WriteLine($"Resultado: {varDoubleNumUm} - {varDoubleNumDois} = " + (varDoubleNumUm - varDoubleNumDois));
                    break;
                case "*":
                    Console.WriteLine($"Resultado: {varDoubleNumUm} * {varDoubleNumDois} = " + (varDoubleNumUm * varDoubleNumDois));
                    break;
                case "/":
                    // Peça ao usuário para inserir um divisor diferente de zero até que ele faça isso.
                    if (varDoubleNumDois != 0) 
                    {
                        result = varDoubleNumUm / varDoubleNumDois;
                    }

                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
