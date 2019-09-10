using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaBancario;

namespace SistemaBancario
{
    public partial class FormVisaoDasContas : Form
    {

        FormCriarContas varSistemaBancario;
        public FormVisaoDasContas()
        {
            varSistemaBancario = new FormCriarContas();
           
            InitializeComponent();
            
        } 


        private void VisaoDasContas_Load(object sender, EventArgs e)
        {
            
        }

        public void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Button5EntrarNaConta_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button3EditarConta_Click(object sender, EventArgs e)
        {

        }

        private void Button4Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1ExcluirConta_Click(object sender, EventArgs e)
        {
            
        }

        private void VerContas_Click(object sender, EventArgs e)
        {
            
        }
    }
}
