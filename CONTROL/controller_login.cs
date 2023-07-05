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
        int cont = 0;

        public int id = 0;
        public int login(User us)
        {
            try
            {
                ConsultarDados consu = new ConsultarDados();
                MySqlDataReader dt = consu.select("select id_funcionario from tb_funcionario  where usuario_funcionario = '" + us.Getuser() + "' and senha_funcionario = '" + us.Getsenha() + "'");
                while (dt.Read())
                {
                   id = Convert.ToInt32(dt.GetString("id_funcionario"));
                }
            }catch
            {
                id = 0;
            }

            return id;
        }

        

    }
}
