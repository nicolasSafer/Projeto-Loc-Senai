using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class User
    {
        public int CodigoUsuario;
        string nome_funcionario;
        string senha_funcionario;
        string email_funcionario;
        string user_funcionario;
        string funcao_funcionario;
        
        public User()
        {
            //construindo o metodo com as varaiveis vazias
            CodigoUsuario = 0;
            nome_funcionario = "";
            senha_funcionario = "";
            email_funcionario = "";
            user_funcionario = "";
            funcao_funcionario= "";
        }
        public int Codigo
        {
            get { return CodigoUsuario; }
            set { CodigoUsuario = value; }
        }
        public string GetNome()
        {
            return this.nome_funcionario;
        }
        public string Getsenha()
        {
            return this.senha_funcionario;
        }
        public string Getfuncao_funcionario()
        {
            return this.funcao_funcionario;
        }
        public string Getemail()
        {
            return this.email_funcionario;
        }
        public string Getuser()
        {
            return this.user_funcionario;
        }

        // set's
        public void setnome(string nome)
        {
            this.nome_funcionario = nome;

        }
        public void setfuncao_funcionario(string funcao_funcionario)
        {
            this.funcao_funcionario = funcao_funcionario;
        }
        public void setsenha(string senha)
        {
            this.senha_funcionario = senha;
        }
        public void setemail(string email)
        {
            this.email_funcionario = email;

        }
        public void setuser(string user)
        {
            this.user_funcionario = user;

        }

        public string GetString(int v)
        {
            throw new NotImplementedException();
        }
    }
}
