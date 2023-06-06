using MODEL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;

namespace CONTROL
{
   public class controller_sala
    {
        bool resultado = false;
        conexao con = new conexao();
        string sql;
        
        


        public bool insertsala(m_sala SL)
        {
            try
            {
                //"insert into tb_sala_do_predio(nome_sala,descricao_sala,numeracao,bloco) values (@nome_sala,@descricao_sala,@numeracao,@bloco)"
                sql = "insert into tb_sala_do_predio(nome_sala,descricao_sala,numeracao,bloco) values (@nome_sala,@descricao_sala,@numeracao,@bloco)";
                string[] campos = { "@nome_sala", "@descricao_sala", "@numeracao", "@bloco" };
                string[] valores = { SL.Getnome_sala(), SL.Getdescricao_sala(), SL.Getbloco_sala(), SL.Getnumeracao_sala()};
                if (con.cadastrar(campos, valores, sql) >= 1)
                {
                    return resultado = true;
                }
                else
                {
                    return resultado = false;
                }
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        public bool updatesala(m_sala ums)
        {
            try
            {
                sql = "UPDATE tb_sala_do_predio set nome_sala = @nome_sala, descricao_sala = @descricao_sala, numeracao = @numeracao, bloco = @bloco where id_sala=@codigo";
                string[] campos = { "@nome_sala", "@descricao_sala", "@numeracao", "@bloco" };//falta o id_sala
                string[] valores = { ums.Getnome_sala(), ums.Getdescricao_sala(), ums.Getnumeracao_sala(), ums.Getbloco_sala() };
                if (con.atualizarDados(ums.codigosala, campos, valores, sql) >= 1)
                {
                    return resultado = true;
                }
                else
                {
                    return resultado = false;
                }
            }
            catch (System.Exception ex)
            {
                throw ex;

            }
        }
        public bool ExcluiSala(m_sala sala)
        {
            sql = "delete from tb_sala_do_predio where id_sala = @codigo";
            try
            {
                con.apagar(sala.codigosala,sql);
                resultado= true;
            }
            catch
            {
                resultado= false;
            }
            return resultado;
        }
        bool selectok = false;
        int cont = 0;
        public bool selectasala(m_sala sl)
        {
            try
            {
                ConsultarDados consu = new ConsultarDados();
                MySqlDataReader dr = consu.select("select * from tb_sala_do_predio ");

                while (dr.Read())
                {
                    cont++;
                }
                if (cont == 0)
                {
                    selectok = false;
                }
                else
                {
                    selectok = true;
                }

            }
            catch
            {
                selectok = false;
            }

            return selectok;
        }

    }
}
