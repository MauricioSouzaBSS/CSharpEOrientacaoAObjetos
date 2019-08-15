
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBancario
{
    public partial class FormMENUINICIAL : Form
    {


        public FormMENUINICIAL()
        {
            InitializeComponent();
        }

        private void ButtonAcessarSistemaBancario_Click(object sender, EventArgs e)
        {
            FormSistemaBancario formSistemaBancario = new FormSistemaBancario();
            formSistemaBancario.ShowDialog();
            this.Close();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
           

        }
    }
}
