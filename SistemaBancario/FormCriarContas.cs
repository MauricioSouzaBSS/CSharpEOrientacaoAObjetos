﻿using System;
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
            caixadeCpf.Clear();
            caixadeNumero.Clear();
            caixadeEndereco.Clear();
            caixadeSaldo.Clear();
            Cliente cliente = new Cliente();
            cliente.Nome = nomeCliente;
            cliente.AdicionarConta(0.10);
            string saldoCliente = caixadeSaldo.Text;
            MessageBox.Show("Cliente: " + nomeCliente +"\n\n"+ 
                "Salvado com Sucesso ! " + "\n\n" +
                "Com Saldo de: " + saldo  );
        }
    }
}
