using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conta
{
    class conta
    {
        public int numero;
        public string titular;
        public double saldo;
    }

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conta c = new conta();
            c.numero = 1;
            c.titular = "Victor";
            c.saldo = 100;
            c.saldo -= 50.0;
            
            if(c.saldo >= 100.0)
            {
                c.saldo -= 100.0;
            }
            MessageBox.Show(this.saldo);
        }
    }
    
}
