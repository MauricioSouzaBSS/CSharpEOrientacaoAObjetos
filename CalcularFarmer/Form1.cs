using System;
using System.Windows.Forms;

namespace CalcularFarmer
{

    public partial class Form1 : Form
    {
        Farmer farmer;
        public Form1()
        {
            InitializeComponent();
            farmer = new Farmer(15, 30) ;
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            farmer.NumberOfCows = (int)numericUpDown1.Value;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            string numeroDeVacas = String.Format("I Need {0} bags of feed for {1} cows",
                farmer.BagsOfFeed, farmer.NumberOfCows);
            Console.WriteLine(numeroDeVacas);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}