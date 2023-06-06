using MODEL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;

namespace CONTROL
{
    public class controller_login
    {
        bool resultado = false;
        conexao con = new conexao();
        bool logado = false;
        int cont = 0;

        string nome;
        string email;
        string funcao;
        public int id_on;
        public bool login(User us)
        {
            try
            {
                ConsultarDados consu = new ConsultarDados();
                MySqlDataReader dt = consu.select("select tb_funcionario.nome_funcionario, tb_funcionario.senha_funcionario from tb_funcionario  where usuario_funcionario = '" + us.Getuser() + "' and senha_funcionario = '" + us.Getsenha() + "'");
                while (dt.Read())
                {
                    cont++;
                }
                if(cont == 0)
                {
                    logado = false;
                }
                else
                {
                    logado = true;
                  


                }
                // id_on = Convert.ToInt32(us.GetString(0));

            }catch
            {
                logado =false;
            }

            return logado;
        }

        

    }
}
