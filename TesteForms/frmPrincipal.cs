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

namespace TesteForms {
    public partial class frmPrincipal : Form {
        public frmPrincipal(Funcionarios func) {
            InitializeComponent();
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
        }

        public string PadBoth(string source, int length) {
            int spaces = length - source.Length;
            int padLeft = spaces / 2 + source.Length;
            return source.PadLeft(padLeft).PadRight(length);

        }

        private void btnSelecionarLocal_Click(object sender, EventArgs e) {

        }
    }
}
