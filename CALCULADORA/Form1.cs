using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA
{
    public partial class Form1 : Form
    {
        int startingMileage;
        int endingMileage;
        double milesTraveled;
        double reimburseRate = .39;
        double amountOwed;

        public Form1()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
     
            startingMileage = (int) numericUpDown1.Value;
            endingMileage = (int) numericUpDown2.Value;

            if (startingMileage <= endingMileage)
            {
                milesTraveled = endingMileage - startingMileage;
                amountOwed = milesTraveled * reimburseRate;
                label4.Text = "$" + amountOwed;

            }
            else
            {
                MessageBox.Show("A quilometragem inicial deve ser menor que a quilometragem fina, Impossivel Calcular ");

            }

        }
        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTraveled + "miles Traveled");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void AmountOwed_Click(object sender, EventArgs e)
        {

        }

        private void EndindMileage_Click(object sender, EventArgs e)
        {
            
        }

        private void StartingMileage_Click(object sender, EventArgs e)
        {
            
        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }


    }
}
