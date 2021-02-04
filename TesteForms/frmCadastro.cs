using System;
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

namespace TesteForms.Desktop {
    public partial class frmCadastro : Form {
        public frmCadastro() {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e) {
            txtUsuario.Clear();
            txtSenha.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            Funcionarios novo = new Funcionarios();
            novo.Login_funcionario = txtUsuario.Text;
            novo.Senha_funcionario = txtSenha.Text;
            Servico.Salvar(novo);
            MessageBox.Show("O funcionário foi salvo com sucesso!");
            this.Close();
        }
    }
}
