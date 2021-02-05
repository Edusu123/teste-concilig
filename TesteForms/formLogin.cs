using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteForms.Desktop;
using Teste.Model;
using Teste.Model.Entidades;

namespace TesteForms {
    public partial class frmLogin : Form {
        public frmLogin() {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e) {
            txtUsuario.Clear();
            txtSenha.Clear();
        }

        private void btnCadastro_Click(object sender, EventArgs e) {
            new frmCadastro().Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e) {
            Funcionarios func = new Funcionarios();
            List<Funcionarios> lista = new List<Funcionarios>();
            lista = Servico.Login(txtUsuario.Text, txtSenha.Text);
            if (lista.Any()) {
                func = lista[0];
                this.Hide();
                Form f = new frmPrincipal(func);
                f.Closed += (s, args) => this.Close();
                f.Show();
            }
            else {
                MessageBox.Show("Nome de usuário ou senha incorreto(s)!");
            }
        }
    }
}
