using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Teste.Model;
using Teste.Model.Entidades;
using TesteForms.Desktop;

namespace TesteForms {
    public partial class frmPrincipal : Form {

        private List<Contratos> contratos = new List<Contratos>();

        public frmPrincipal(Funcionarios func) {
            InitializeComponent();
            lblNome.Text = func.Login_funcionario;
        }

        private void frmPrincipal_Load(object sender, EventArgs e) {
            StreamReader stream = new StreamReader(@"C:\tudo\teste_concilig\files\contratos.csv", Encoding.Default);
            string linha = null;
            while((linha = stream.ReadLine()) != null) {
                string[] coluna = linha.Split(';');
                string cadeia1 = PadBoth(coluna[2], 20);
                string cadeia2 = PadBoth(coluna[4], 10);
                string cadeia3 = PadBoth(coluna[5], 20);
                string cadeia4 = PadBoth(coluna[3], 35);
                string cadeia_final = cadeia1 + cadeia2 + cadeia3 + cadeia4;
                lstContratosLocal.Items.Add(cadeia_final);
            }
            lstContratosDatabase.Items.Clear();
            contratos = Servico.BuscarContrato();
            foreach(Contratos contrato in contratos) {
                lstContratosDatabase.Items.Add(contrato.toString());
            }
        }

        public string PadBoth(string source, int length) {
            int spaces = length - source.Length;
            int padLeft = spaces / 2 + source.Length;
            return source.PadLeft(padLeft).PadRight(length);

        }

        private void btnSelecionarLocal_Click(object sender, EventArgs e) {
            // encontrando o objContrato referente à linha selecionada
            string itens = lstContratosLocal.SelectedItem.ToString();
            string[] vet = itens.Split(' ');
            string num_contrato = "";
            foreach(string item in vet) {
                if(item != "") {
                    num_contrato = item;
                    break;
                }
            }
            StreamReader stream = new StreamReader(@"C:\tudo\teste_concilig\files\contratos.csv", Encoding.Default);
            string linha = null;
            string nome = "";
            string cpf = "";
            string produto = "";
            string vencimento = "";
            string valor = "";
            while ((linha = stream.ReadLine()) != null) {
                string[] coluna = linha.Split(';');
                if(num_contrato == coluna[2]) {
                    nome = coluna[0];
                    cpf = coluna[1];
                    produto = coluna[3];
                    vencimento = coluna[4];
                    valor = coluna[5];
                }
            }
            List<Funcionarios> lista = new List<Funcionarios>();
            Funcionarios func = new Funcionarios();
            lista = Servico.BuscarFuncionario(lblNome.Text);
            func = lista[0];
            new frmContratoLocal(nome, cpf, num_contrato, produto, vencimento, valor, func).Show();
        }

        private void frmPrincipal_Activated(object sender, EventArgs e) {
            lstContratosDatabase.Items.Clear();
            contratos = Servico.BuscarContrato();
            foreach (Contratos contrato in contratos) {
                lstContratosDatabase.Items.Add(contrato.toString());
            }
        }
    }
}
