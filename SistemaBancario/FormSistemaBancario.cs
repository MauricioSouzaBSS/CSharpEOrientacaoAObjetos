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
    public partial class FormSistemaBancario : Form
    {       
        public FormSistemaBancario()
        {
            InitializeComponent();
        }
        private void FormSistemaBancario_Load(object sender, EventArgs e)
        {

        }
        private void CriarConta_Click(object sender, EventArgs e)
        {
            FormCriarContas formCriarContas = new FormCriarContas();
            formCriarContas.ShowDialog();

        }
        private void VerContas_Click(object sender, EventArgs e)
        {
            FormVisaoDasContas visaoDasContas = new FormVisaoDasContas();
            visaoDasContas.ShowDialog();
        }
        private void SairSistema_Click(object sender, EventArgs e)
        {
        }
    }
}
