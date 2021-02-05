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
    public partial class frmHistorico : Form {
        public frmHistorico() {
            InitializeComponent();
        }

        private void frmHistorico_Load(object sender, EventArgs e) {
            lstHistorico.Items.Clear();
            List<Contratos> lista = new List<Contratos>();
            lista = Servico.BuscarContrato();
            foreach(Contratos contrato in lista) {
                lstHistorico.Items.Add(contrato.toStringHistorico());
            }
        }
    }
}
