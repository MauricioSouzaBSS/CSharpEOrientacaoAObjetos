﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = new string[3];
            a[0] = "Mauricio";
            a[1] = "Sheila";
            a[2] = "Lana";

            Array.Sort(a);

            foreach (string nome in a)
            {
                Console.WriteLine(nome);
            }
            Console.Read();
        }
    }
}
