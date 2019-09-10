using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivroPag113
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;


        public Form1()
        {
            InitializeComponent();

            bob = new Guy() { Cash = 100, Name = "Bob" };
            joe = new Guy() { Cash = 50, Name = "Joe" };
            //bob = new Guy();
            //bob.Name = "Bob";
            //bob.Cash = 100;

            //joe = new Guy();
            //joe.Name = "Joe";
            //joe.Cash = 50;

            UpdateForm();
        }
        public void UpdateForm()
        {
            button1.Text = joe.Name + " Tem $" + joe.Cash;
            button2.Text = bob.Name + "Tem $" + bob.Cash;
            bankCashLabel.Text = "O Banco Tem $" + bank;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void Button2_Click_1(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("O Banco ficou sem Dinheiro");
            }

        }

        private void BobGivesToJoes_Click(object sender, EventArgs e)
        {
            bob.ReceiveCash(joe.GiveCash(10));
            UpdateForm();
        }

        private void JoeGivesToBob_Click(object sender, EventArgs e)
        {
      
        }

        private void JoesCashLabel_Click(object sender, EventArgs e)
        {
      
        }



        private void BankCashLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

    class Guy
{
    public string Name;
    public int Cash;

    public int GiveCash(int amount)
    {
        if (amount <= Cash && amount > 0) 
        {
            Cash -= amount;
            return amount;
        }
        else
        {
            MessageBox.Show("Eu não tenho dinheiro suficiente para lhe dar " + amount, Name + " Diz...");
            return 0;
        }
    }

    public int ReceiveCash(int amount)
    {
        if (amount >0)
        {
            Cash += amount;
            return amount;
        }
        else
        {
            MessageBox.Show(amount + " não é uma quantidade que eu vou levar", Name + " Diz...");
            return 0;
        }
    }
}

