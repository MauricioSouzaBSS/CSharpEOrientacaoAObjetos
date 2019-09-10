using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrirAQ
{
    class Program
    {
        public static void LerArq(string nomeArquivo)
        {
            string arquivoComCaminho = @"C:\Mauricio\ArquivoMauricio.txt  ";

            if (File.Exists(arquivoComCaminho))
            {
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            LerArq(@"C:\Mauricio\ArquivoMauricio.txt  ");
            Console.ReadKey();
        }

        public const int SAIDA_PROGRAMA = 1;

        public void Sair()
        {
            while (true)
            {
                Console.WriteLine("Digite " + SAIDA_PROGRAMA + " para sair do programa");
                int valor = int.Parse(Console.ReadLine());
                if (SAIDA_PROGRAMA == valor)
                {
                    break;
                }
            }
        }
    }
}
