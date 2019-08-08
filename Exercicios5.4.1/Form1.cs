using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios5._4._1
{
    public partial class Form1 : Form
    {
        int total = 2;
        public Form1()
        {
            for (int i = 0; i < 5; i += 1)
            {
                total = total * 3;
            }
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("O Total é: " + total);
        }
    }
}
