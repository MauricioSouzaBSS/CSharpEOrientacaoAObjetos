using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioPag147
{
    public partial class Form1 : Form
    {
        Elephant lucinda;
        Elephant Lloyd;
        public Form1()
        {
            InitializeComponent();
            lucinda = new)
            { Name = "Lucinda ", EarSize = 33 };
            Lloyd = new Elephant()
            { Name = "lloyd", EarSize = 40 };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Elephant holder;
            holder = Lloyd;
            Lloyd = lucinda;
            lucinda = holder;
            MessageBox.Show("Objects swapped");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Lloyd.WhoAmI();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Lloyd = lucinda;
            Lloyd.EarSize = 4321;
            Lloyd. WhoAmI();
        }
    }
}
