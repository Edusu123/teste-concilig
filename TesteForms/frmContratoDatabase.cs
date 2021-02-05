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
    public partial class frmContratoDatabase : Form {
        public frmContratoDatabase(Contratos contrato) {
            InitializeComponent();
            lblNomeInsert.Text = contrato.Cliente_contrato.Nome_cliente;
            lblCPFInsert.Text = contrato.Cliente_contrato.Cpf_cliente;
            lblProdutoInsert.Text = contrato.Produto_contrato;
            lblVencimentoInsert.Text = contrato.Vencimento_contrato.ToShortDateString();
            lblValorInsert.Text = contrato.Valor_contrato.ToString();
            lblFuncionatioInsert.Text = contrato.Funcionario_contrato.Login_funcionario;
        }
    }
}
