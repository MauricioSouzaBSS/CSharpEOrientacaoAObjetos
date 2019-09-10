using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo2Pag70
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 

            int j = 2;
            for (int i = 1; i < 100; i = i * 2) 
            {
                j = j - i;
                while (j < 25)
                {
                    j = j + 5;
                }
            }
            MessageBox.Show("The result is " + j);
        }
    }
}
