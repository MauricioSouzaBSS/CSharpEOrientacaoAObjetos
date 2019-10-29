using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColectionList
{
    class Program
    {
        static void Main(string[] args)
        {
            List <string> a = new List<string> ();
            a.Add("Mauricio");
            a.Add("sheila");
            a.Add("lana2");

            foreach(string nome in a)
            {
                Console.WriteLine(nome);
            }
            Console.Read();
        }
    }
}

