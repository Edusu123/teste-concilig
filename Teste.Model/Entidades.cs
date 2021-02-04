using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Model.Entidades {
    class Entidades {
        public class Funcionarios {
            private Int64 id_funcionario;
            private string login_funcionario;
            private string senha_funcionario;

            public Int64 Id_funcionario {
                get {
                    return id_funcionario;
                }
                set {
                    id_funcionario = value;
                }
            }

            public string Login_funcionario {
                get {
                    return login_funcionario;
                }
                set {
                    if(value.Length <= 3) {
                        throw new ApplicationException("O tamanho do nome de usuário não deve ser menor do que 3;");
                    }
                    else {
                        login_funcionario = value;
                    }
                }
            }

            public string Senha_funcionario {
                get {
                    return senha_funcionario;
                }
                set {
                    if(value.Length <= 8) {
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
                get {
                    return id_cliente;
                }
                set {
                    id_cliente = value;
                }
            }

            public string Nome_cliente {
                get {
                    return nome_cliente;
                }
                set {
                    nome_cliente = value;
                }
            }

            public string Cpf_cliente {
                get {
                    return cpf_cliente;
                }
                set {
                    cpf_cliente = value;
                }
            }
            public string Arquivo_cliente {
                get {
                    return arquivo_cliente;
                }
                set {
                    arquivo_cliente = value;
                }
            }
            public Funcionarios Funcionario_cliente {
                get {
                    return funcionario_cliente;
                }
                set {
                    funcionario_cliente = value;
                }
            }
        }
    }
}
