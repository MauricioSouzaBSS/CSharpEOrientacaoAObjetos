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
            farmer = new Farmer() { NumberOfCows = 15 };
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            farmer.NumberOfCows = (int)numericUpDown1.Value;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            Console.WriteLine("I Need {0} bags of feed for {1} cows",
                farmer.BagsOfFeed, farmer.NumberOfCows);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }

}
