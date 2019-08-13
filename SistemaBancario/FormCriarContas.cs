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
    public partial class FormCriarContas : Form
    {
        public FormCriarContas()
        {
            InitializeComponent();
        }

        private void FormCriarContas_Load(object sender, EventArgs e)
        {

        }

 

        private void Cpf_Click(object sender, EventArgs e)
        {

        }

        private void Rg_Click(object sender, EventArgs e)
        {

        }

        private void Endereço_Click(object sender, EventArgs e)
        {

        }

        private void Numero_Click(object sender, EventArgs e)
        {

        }

        private void Nome_Click(object sender, EventArgs e)
        {
           
        }



        private void Saldo_Click(object sender, EventArgs e)
        {

        }

        private void CaixadeNome_TextChanged(object sender, EventArgs e)
        {
                  
        }

        private void CaixadeSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void CaixadeCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void CaixadeRg_TextChanged(object sender, EventArgs e)
        {

        }

        private void CaixadeEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void CaixadeNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void CriarESalvar_Click(object sender, EventArgs e)
        {

            
            var a = caixadeNome.Text;
            var b = caixadeRg.Text;
            var c = caixadeCpf.Text;
            var d = caixadeNumero.Text;         
            var g = caixadeEndereco.Text;
            var f = caixadeSaldo.Text;
            
            MessageBox.Show("Salvado com Sucesso ! " + "\n\n" + a );

        }
    }
}
