using MODEL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3;

namespace CONTROL
{
    public class PesquisaSala:conexao
    {
        
        MySqlCommand cmd = null;
        MySqlDataReader dr = null;
        m_sala m_sala = null;
        string sql;
        public IEnumerable<m_sala> Pesquisar(string sala)
        {
            try
            {
                conn = getconexao();
                conn.Open();
                sql = "select * from tb_sala_do_predio where nome_sala like @sala"; 
                cmd = new MySqlCommand(sql, conn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@sala", sala+"%");
                dr = cmd.ExecuteReader();
            }
            catch
            {
                
            }
            
            while (dr.Read())
            {
                m_sala = new m_sala();
                m_sala.setnome_sala(dr.GetString("nome_sala"));
                m_sala.setbloco_sala(dr.GetString("bloco"));
                m_sala.setdescricao_sala(dr.GetString("descricao_sala"));
                m_sala.setnumeracao_sala(dr.GetString("numeracao"));
                yield return m_sala;
            } 

            
           
            
            

            
            
        }

    }
}
