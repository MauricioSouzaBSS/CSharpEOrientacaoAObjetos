using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncaoRecursivaLerTXT
{
    class Program
    {
           // public static void LerArquivo(string nomeArquivo)
            public static void LerArquivo(int numeroArquivo)
        {
           // string arquivoComCaminho = @"C:\Mauricio\ArquivoMauricio.txt";
            string arquivoComCaminho = @"C:\Mauricio\ArquivoMauricio" + numeroArquivo + ".txt";
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
            string arquivoComCaminho2 = @"C:\Mauricio\ArquivoMauricio" + (numeroArquivo + 1) + ".txt";
            if (File.Exists(arquivoComCaminho2))
            {
                LerArquivo(numeroArquivo + 1);
            }
        }
        static void Main(string[] args)
        {
           // LerArquivo(@"C:\Mauricio\ArquivoMauricio.txt");
            LerArquivo(1);
           
            Console.ReadKey();

        }


    }
}
