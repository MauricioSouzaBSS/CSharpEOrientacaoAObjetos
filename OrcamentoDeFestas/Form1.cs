using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrcamentoDeFestas
{
    public partial class Form1 : Form
    {
        ClasseOrcamentoFesta classeOrcamentoFesta;
        BirthdayParty birthdayParty;

        public Form1()
        {

            InitializeComponent();

            classeOrcamentoFesta = new ClasseOrcamentoFesta((int)numericUpDown1.Value,
                                            healthyBox.Checked, fancyBox.Checked);

            DisplayClasseOrcamentoFestaCost();

            birthdayParty = new BirthdayParty((int)numberBirthday.Value, fancyBirthday.Checked, cakeWriting.Text);

            DisplayBirthdayPartyCost();

            classeOrcamentoFesta = new ClasseOrcamentoFesta() { QuantidadeDePessoas = 5 };
            classeOrcamentoFesta.CalcularCustoDeDecoracao(comDecoracao.Checked);
            classeOrcamentoFesta.DefinirOpcaoSaudavel(semAlcool.Checked);

        }
        private void numberBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numberBirthday.Value;
            DisplayBirthdayPartyCost();
        }
        private void fancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.CalculateCostOfDecorations(fancyBirthday.Checked);
            DisplayBirthdayPartyCost();
        }

        private void ComDecoracao_CheckedChanged(object sender, EventArgs e)
        {
            classeOrcamentoFesta.CalcularCustoDeDecoracao(comDecoracao.Checked);
                DisplayClasseOrcamentoFestaCost();
        }

        private void SemAlcool_CheckedChanged(object sender, EventArgs e)
        {
            classeOrcamentoFesta.DefinirOpcaoSaudavel(semAlcool.Checked);
                DisplayClasseOrcamentoFestaCost();
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            classeOrcamentoFesta.QuantidadeDePessoas = (int)numericUpDown1.Value;
                DisplayClasseOrcamentoFestaCost();
        }
        private void DisplayClasseOrcamentoFestaCost()
        {
            decimal Cost = classeOrcamentoFesta.CalcularCusto(semAlcool.Checked);
            costLabel.Text = Cost.ToString("c");
        }


        private void CostLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FancyBirthday_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NumberBirthday_TextChanged(object sender, EventArgs e)
        {

        }

        private void BirthdayCost_Click(object sender, EventArgs e)
        {

        }
    }
}
