using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioPag210
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    class CableBill
    {
        private int rentalFee;
        public CableBill (int rentalFee)
        {
            this.rentalFee = rentalFee;
            discount = false;
        }
        private int payPerViewDiscount;
        private bool discount;
        public bool Discount
        {
            set
            {
                discount = value;
                if (discount)
                    payPerViewDiscount = 2;
                else
                    payPerViewDiscount = 0;
            }
        }
        public int CalculateAmount(int payPerViewMoviesOrdered)
        {
            return (rentalFee - payPerViewDiscount) * payPerViewMoviesOrdered;
        }


    }

}
