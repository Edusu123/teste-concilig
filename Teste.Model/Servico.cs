using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Teste.Model.Entidades;
using Teste.Model.Suporte;

namespace Teste.Model {
    class Servico {
        // Métodos de criação de objetos para manipulação dos dados:
        public static Funcionarios objFuncionario(ref NpgsqlDataReader dtr) {
            Funcionarios func = new Funcionarios();
            func.Id_funcionario = Convert.ToInt64(dtr["id_funcionario"]);
            func.Login_funcionario = Convert.ToString(dtr["login_funcionario"]);
            return func;
        }
        public static Clientes objCliente(ref NpgsqlDataReader dtr) {
            Clientes cliente = new Clientes();
            cliente.Id_cliente = Convert.ToInt64(dtr["id_cliente"]);
            cliente.Nome_cliente = Convert.ToString(dtr["nome_cliente"]);
            cliente.Cpf_cliente = Convert.ToString(dtr["cpf_cliente"]);
            cliente.Arquivo_cliente = Convert.ToString(dtr["arquivo_cliente"]);
            cliente.Funcionario_cliente = objFuncionario(ref dtr);
            return cliente;
        }
        public static Contratos objContrato(ref NpgsqlDataReader dtr) {
            Contratos contrato = new Contratos();
            contrato.Id_contrato = Convert.ToInt64(dtr["id_contrato"]);
            contrato.Num_contrato = Convert.ToString(dtr["num_contrato"]);
            contrato.Cliente_contrato = objCliente(ref dtr);
            contrato.Produto_contrato = Convert.ToString(dtr["produto_contrato"]);
            contrato.Vencimento_contrato = Convert.ToDateTime(dtr["vencimento_contrato"]);
            contrato.Valor_contrato = Convert.ToDouble(dtr["valor_contrato"]);
            contrato.Arquivo_contrato = Convert.ToString(dtr["arquivo_contrato"]);
            contrato.Funcionario_contrato = objFuncionario(ref dtr);
            contrato.Data_contrato = Convert.ToDateTime(dtr["data_contrato"]);
            return contrato;
        }
    }
}
