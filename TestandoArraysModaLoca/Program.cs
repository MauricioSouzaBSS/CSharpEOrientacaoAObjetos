using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestandoArraysModaLoca
{


    class Program
    {
        static void Main(string[] args)
        {

            Aluno[] alunos1 = new Aluno[5]
            {
                new Aluno { Nome = "João"},
                new Aluno { Nome = "Maria"},
                new Aluno { Nome = "Pedro"},
                new Aluno { Nome = "Carlos"},
                new Aluno { Nome = "Tereza"}
            };

                foreach (Aluno aluno in alunos1)
            {
                Console.WriteLine(aluno.Nome);
            }
           
            Console.Read();

        }
    }

}
