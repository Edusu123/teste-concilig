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
                    login_funcionario = value; //fazer verificação de tamanho de nome de usuário
                }
            }

            public string Senha_funcionario {
                get {
                    return senha_funcionario;
                }
                set {
                    senha_funcionario = value; //fazer verificação de tamanho de senha
                }
            }
        }
    }
}
