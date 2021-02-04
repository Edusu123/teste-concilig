using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }
    }
}
