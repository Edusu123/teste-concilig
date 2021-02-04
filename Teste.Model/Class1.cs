using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace Teste.Model.Suporte {
    public class ConexaoBanco {
        //Criação da variável de conexão: 
        static string stringConexao = "Server = localhost; Database = testeConcilig; User ID = postgres; password = postgres";

        static NpgsqlConnection cn;

        public static void conectar() {
            if(cn == null) {
                cn = new NpgsqlConnection();
            }
            try {
                if(cn.State != ConnectionState.Open) {
                    cn.ConnectionString = stringConexao;
                    cn.Open();
                }
            }
            catch(NpgsqlException err) {
                throw new ApplicationException(err.Message);
            }
        }

        public static void desconectar() {
            cn.Close(); // fecha a conexão com o banco de dados
            cn.Dispose(); // libera os recursos utilizados
            cn = null;
        }
    }
}
