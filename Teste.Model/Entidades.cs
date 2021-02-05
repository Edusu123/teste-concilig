using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Model.Entidades {
    public class Funcionarios {
        private Int64 id_funcionario;
        private string login_funcionario;
        private string senha_funcionario;

        public Int64 Id_funcionario {
            get { return id_funcionario; }
            set { id_funcionario = value; }
        }

        public string Login_funcionario {
            get { return login_funcionario; }
            set {
                if (value.Length <= 3) {
                    throw new ApplicationException("O tamanho do nome de usuário não deve ser menor do que 3;");
                }
                else {
                    login_funcionario = value;
                }
            }
        }

        public string Senha_funcionario {
            get { return senha_funcionario; }
            set {
                if (value.Length <= 8) {
                    throw new ApplicationException("O tamanho da senha não deve ser menor do que 8;");
                }
                else {
                    senha_funcionario = value;
                }
            }
        }
    }
    public class Clientes {
        private Int64 id_cliente;
        private string nome_cliente;
        private string cpf_cliente;
        private string arquivo_cliente;
        private Funcionarios funcionario_cliente;

        public Int64 Id_cliente {
            get { return id_cliente; }
            set { id_cliente = value; }
        }

        public string Nome_cliente {
            get { return nome_cliente; }
            set { nome_cliente = value; }
        }

        public string Cpf_cliente {
            get { return cpf_cliente; }
            set { cpf_cliente = value; }
        }
        public string Arquivo_cliente {
            get { return arquivo_cliente; }
            set { arquivo_cliente = value; }
        }
        public Funcionarios Funcionario_cliente {
            get { return funcionario_cliente; }
            set { funcionario_cliente = value; }
        }
    }
    public class Contratos {
        private Int64 id_contrato;
        private string num_contrato;
        private Clientes cliente_contrato;
        private string produto_contrato;
        private DateTime vencimento_contrato; //não esquecer de tratar o dado antes de enviar para o banco
        private double valor_contrato;
        private string arquivo_contrato;
        private Funcionarios funcionario_contrato;
        private DateTime data_contrato; //data de inserção no banco de dados

        public Int64 Id_contrato {
            get { return id_contrato; }
            set { id_contrato = value; }
        }

        public string Num_contrato {
            get { return num_contrato; }
            set { num_contrato = value; }
        }

        public Clientes Cliente_contrato {
            get { return cliente_contrato; }
            set { cliente_contrato = value; }
        }

        public string Produto_contrato {
            get { return produto_contrato; }
            set { produto_contrato = value; }
        }

        public DateTime Vencimento_contrato {
            get { return vencimento_contrato; }
            set { vencimento_contrato = value; }
        }

        public double Valor_contrato {
            get { return valor_contrato; }
            set { valor_contrato = value; }
        }

        public string Arquivo_contrato {
            get { return arquivo_contrato; }
            set { arquivo_contrato = value; }
        }

        public Funcionarios Funcionario_contrato {
            get { return funcionario_contrato; }
            set { funcionario_contrato = value; }
        }

        public DateTime Data_contrato { // data de inserção no banco de dados
            get { return data_contrato; }
            set { data_contrato = value; }
        }

        public String toString() {
            return num_contrato +  ", " + vencimento_contrato.ToShortDateString() + ", R$" + valor_contrato + ", " + produto_contrato;
        }

    }
}
