using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaBancario.Classes;
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
            string nomeCliente = caixadeNome.Text;
            string rgCliente = caixadeRg.Text;
            string cpfCliente = caixadeCpf.Text;
            string numeroCliente = caixadeNumero.Text;         
            string enderecoCliente = caixadeEndereco.Text;
            string saldo = caixadeSaldo.Text;

            caixadeNome.Clear();
            caixadeRg.Clear();
            caixadeCpf.Clear();         // Limpar Campos
            caixadeNumero.Clear();
            caixadeEndereco.Clear();
            caixadeSaldo.Clear();

            Cliente cliente = new Cliente();  // OBJETO

            cliente.CPF = cpfCliente;
            cliente.RG = rgCliente;
            cliente.Numero = numeroCliente;
            cliente.Endereco = enderecoCliente;
            cliente.Nome = nomeCliente;

            BancoDeDados.SalvarCliente(cliente);   //SALVAR

            cliente.AdicionarConta(0.10);    // preço base para salvar caso seja zero o valor da conta

            string saldoCliente = caixadeSaldo.Text;
            MessageBox.Show("Cliente: " + nomeCliente +"\n\n"+ 
                "Salvadooo !! " + "\n\n" +
                "Com Saldo de: " + saldo  );
        }
    }
}
