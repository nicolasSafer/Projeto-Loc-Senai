using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3;
using MySql.Data.MySqlClient;

namespace CONTROL
{
    public class ConsultarDados: conexao
    {
        MySqlCommand cmd = null;
        MySqlDataReader dr = null;
        public MySqlDataReader select(string sql)
        {
            try
            {
                conn = getconexao();
                conn.Open();
                cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = sql;
                dr = cmd.ExecuteReader();
                return dr;
            }
            catch
            {
                return null;
            }
        }
    }
}
