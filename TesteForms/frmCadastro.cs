using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteForms.Desktop {
    public partial class frmCadastro : Form {
        public frmCadastro() {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e) {
            txtUsuario.Clear();
            txtSenha.Clear();
        }
    }
}
