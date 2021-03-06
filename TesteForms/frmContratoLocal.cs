﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teste.Model;
using Teste.Model.Entidades;
using System.Globalization;

namespace TesteForms.Desktop {
    public partial class frmContratoLocal : Form {
        public frmContratoLocal(string nome, string cpf, string num_contrato, string produto, string vencimento, string valor, Funcionarios func) {
            InitializeComponent();
            lblNumero.Text = num_contrato;
            lblNomeInsert.Text = nome;
            lblCPFInsert.Text = cpf;
            lblProdutoInsert.Text = produto;
            lblVencimentoInsert.Text = vencimento;
            lblValorInsert.Text = valor;
            lblFuncionatioInsert.Text = func.Login_funcionario;
        }

        private void btnExportar_Click(object sender, EventArgs e) {
            string cpf_cliente = lblCPFInsert.Text;
            List<Clientes> lista = new List<Clientes>();
            lista = Servico.BuscarClientes(cpf_cliente);
            if (lista.Any()) {
                Clientes cliente = new Clientes();
                cliente = lista[0];
                Contratos contrato = new Contratos();
                contrato.Num_contrato = lblNumero.Text;
                contrato.Cliente_contrato = cliente;
                contrato.Produto_contrato = lblProdutoInsert.Text;
                contrato.Vencimento_contrato = Convert.ToDateTime(lblVencimentoInsert.Text);
                //double valor = Convert.ToDouble(lblValorInsert.Text.Replace(",", "."));
                double valor = double.Parse(lblValorInsert.Text.Replace(",", "."), CultureInfo.InvariantCulture);
                contrato.Valor_contrato = valor;
                Funcionarios func = new Funcionarios();
                List<Funcionarios> listaf = new List<Funcionarios>();
                listaf = Servico.BuscarFuncionario(lblFuncionatioInsert.Text);
                func = listaf[0];
                contrato.Funcionario_contrato = func;
                contrato.Data_contrato = DateTime.Now;
                Servico.Salvar(contrato, valor);
            }
            else {
                Clientes cliente = new Clientes();
                cliente.Nome_cliente = lblNomeInsert.Text;
                cliente.Cpf_cliente = lblCPFInsert.Text;
                Funcionarios func = new Funcionarios();
                List<Funcionarios> listaf = new List<Funcionarios>();
                listaf = Servico.BuscarFuncionario(lblFuncionatioInsert.Text);
                func = listaf[0];
                cliente.Funcionario_cliente = func;
                Servico.Salvar(cliente);
                ///////////////////////////////////////////////////////
                List<Clientes> listac = new List<Clientes>();
                listac = Servico.BuscarClientes(cliente.Cpf_cliente);
                cliente = listac[0];
                Contratos contrato = new Contratos();
                contrato.Num_contrato = lblNumero.Text;
                contrato.Cliente_contrato = cliente;
                contrato.Produto_contrato = lblProdutoInsert.Text;
                contrato.Vencimento_contrato = Convert.ToDateTime(lblVencimentoInsert.Text);
                //double valor = (lblValorInsert.Text.Replace(",", "."));
                double valor = double.Parse(lblValorInsert.Text, CultureInfo.InvariantCulture);
                contrato.Valor_contrato = valor;
                contrato.Funcionario_contrato = func;
                contrato.Data_contrato = DateTime.Now;
                Servico.Salvar(contrato, valor);
            }
            MessageBox.Show("Contrato exportado com sucesso!");
            this.Close();
        }
    }
}
