using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios6._7._2
{
    public partial class Form1 : Form
    {
        Conta contaMauricio;
        Conta contaArthur;


        public Form1()
        {
           InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
                contaMauricio = new Conta();
                contaMauricio.numero = 1;
                contaMauricio.titular = "Maurício";
                contaMauricio.saldo = 3020;


                contaArthur = new Conta();
                contaArthur.numero = 1;
                contaArthur.titular = "Maurício2";
                contaArthur.saldo = 100;
            
                Console.WriteLine(contaArthur.saldo);
                contaArthur.Saca(50);
                Console.WriteLine(contaArthur.saldo);
            
        }
         


        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
