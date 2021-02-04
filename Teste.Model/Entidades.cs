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
    }
}
