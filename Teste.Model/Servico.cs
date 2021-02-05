using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Teste.Model.Entidades;
using Teste.Model.Suporte;

namespace Teste.Model {
    public class Servico {
        // Métodos de criação de objetos para manipulação dos dados:
        public static Funcionarios objFuncionario(ref NpgsqlDataReader dtr) {
            Funcionarios func = new Funcionarios();
            func.Id_funcionario = Convert.ToInt64(dtr["id_funcionario"]);
            func.Login_funcionario = Convert.ToString(dtr["login_funcionario"]);
            func.Senha_funcionario = Convert.ToString(dtr["senha_funcionario"]);
            return func;
        }
        public static Clientes objCliente(ref NpgsqlDataReader dtr) {
            Clientes cliente = new Clientes();
            cliente.Id_cliente = Convert.ToInt64(dtr["id_cliente"]);
            cliente.Nome_cliente = Convert.ToString(dtr["nome_cliente"]);
            cliente.Cpf_cliente = Convert.ToString(dtr["cpf_cliente"]);
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
            contrato.Funcionario_contrato = objFuncionario(ref dtr);
            contrato.Data_contrato = Convert.ToDateTime(dtr["data_contrato"]);
            return contrato;
        }
        public static void Salvar(Funcionarios func) {
            string sql;
            sql = "INSERT INTO funcionarios(login_funcionario, senha_funcionario) VALUES('" + func.Login_funcionario + "', '" + func.Senha_funcionario + "')";
            ConexaoBanco.executar(sql);
        }
        public static void Salvar(Clientes cliente) {
            string sql;
            sql = "INSERT INTO clientes(nome_cliente, cpf_cliente, funcionario_cliente) VALUES('" + cliente.Nome_cliente + "', '" + cliente.Cpf_cliente + "', " + cliente.Funcionario_cliente.Id_funcionario + ")";
            ConexaoBanco.executar(sql);
        }
        public static void Salvar(Contratos contrato, double valor) {
            string sql;
            sql = "INSERT INTO contratos(num_contrato, cliente_contrato, produto_contrato, vencimento_contrato, valor_contrato, funcionario_contrato, data_contrato) VALUES(" + "'" + contrato.Num_contrato + "', " + contrato.Cliente_contrato.Id_cliente + ", '" + contrato.Produto_contrato + "', '" + contrato.Vencimento_contrato.ToShortDateString() + "', " + valor.ToString().Replace(",", ".") + ", " + contrato.Funcionario_contrato.Id_funcionario + ", '" + contrato.Data_contrato.ToShortDateString() + "')";
            ConexaoBanco.executar(sql);
        }
        public static List<Funcionarios> Login(string nome, string senha) { // método utilizado para realizar o login
            List<Funcionarios> funcs = new List<Funcionarios>();
            string sql = "SELECT * FROM funcionarios WHERE login_funcionario = '" + nome + "' and senha_funcionario = '" + senha + "'";
            NpgsqlDataReader dtr = ConexaoBanco.selecionar(sql);
            while (dtr.Read()) {
                funcs.Add(objFuncionario(ref dtr));
            }
            dtr.Close();
            return funcs;
        }
        public static List<Funcionarios> BuscarFuncionario(string nome) { // busca os funcionarios com base no nome de usuário
            List<Funcionarios> funcs = new List<Funcionarios>();
            string sql = "SELECT * FROM funcionarios WHERE login_funcionario = '" + nome + "'";
            NpgsqlDataReader dtr = ConexaoBanco.selecionar(sql);
            while(dtr.Read()) {
                funcs.Add(objFuncionario(ref dtr));
            }
            dtr.Close();
            return funcs;
        }
        public static List<Contratos> BuscarContrato() { // busca todos os contratos
            List<Contratos> contratos = new List<Contratos>();
            string sql = "SELECT * FROM contratos INNER JOIN clientes ON contratos.cliente_contrato = clientes.id_cliente INNER JOIN funcionarios ON contratos.funcionario_contrato = funcionarios.id_funcionario ORDER BY data_contrato";
            NpgsqlDataReader dtr = ConexaoBanco.selecionar(sql);
            while (dtr.Read()) {
                contratos.Add(objContrato(ref dtr));
            }
            dtr.Close();
            return contratos;
        }
        public static List<Contratos> BuscarContrato(string num_contrato) {
            List<Contratos> contratos = new List<Contratos>();
            string sql = "SELECT * FROM contratos INNER JOIN funcionarios ON contratos.funcionario_contrato = funcionarios.id_funcionario INNER JOIN clientes ON contratos.cliente_contrato = clientes.id_cliente WHERE num_contrato = '" + num_contrato + "'";
            NpgsqlDataReader dtr = ConexaoBanco.selecionar(sql);
            while (dtr.Read()) {
                contratos.Add(objContrato(ref dtr));
            }
            dtr.Close();
            return contratos;
        }
        public static List<Clientes> BuscarClientes(string cpf) { // busca clientes com base no CPF
            List<Clientes> clientes = new List<Clientes>();
            string sql = "SELECT * FROM clientes INNER JOIN funcionarios ON clientes.funcionario_cliente = funcionarios.id_funcionario WHERE cpf_cliente = '" + cpf + "'";
            NpgsqlDataReader dtr = ConexaoBanco.selecionar(sql);
            while (dtr.Read()) {
                clientes.Add(objCliente(ref dtr));
            }
            dtr.Close();
            return clientes;
        }
    }
}
