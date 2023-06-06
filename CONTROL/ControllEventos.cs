using MODEL;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3;

namespace CONTROL
{
    
    public class ControllEventos
    {
        bool resultado = false;
        string sql;
        conexao con = new conexao();
        public bool cadastrar(m_evento evento)
        {
            try
            {
                //"insert into tb_sala_do_predio(nome_sala,descricao_sala,numeracao,bloco) values (@nome_sala,@descricao_sala,@numeracao,@bloco)"
                sql = "insert into tb_evento(nome_evento,local_evento,data_evento,horario_evento,descricao_evento,dia_semana) values (@nome,@local,@data,@horario,@descricao,@dia_semana)";
                string[] campos = { "@nome", "@local", "@data", "@horario", "@descricao","@dia_semana" };
                string[] valores = { evento.Getnome_evento(), evento.Getlocal_evento(), evento.Getdata_evento(), evento.Gethorario_evento(), evento.Getdescricao_evento(),evento.Getdia_da_semana() };
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
        public bool updatesala(m_evento mue)
        {
            try
            {
                string sql = "UPDATE tb_evento set nome_evento = @nome_evento, local_evento = @local_evento, data_evento = @data_evento, horario_evento = @horario_evento, descricao_evento = @descricao_evento,dia_semana = @dia_semana where id_evento=@codigo";
                string[] campos = { "@nome_evento", "@local_evento", "@data_evento", "@horario_evento", "@descricao_evento","@dia_semana" };//falta o id_sala
                string[] valores = { mue.Getnome_evento(), mue.Getlocal_evento(), mue.Getdata_evento(), mue.Gethorario_evento(), mue.Getdescricao_evento(), mue.Getdia_da_semana() };
                if (con.atualizarDados(mue.codigoevento, campos, valores, sql) >= 1)
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
        public bool ExcluiEvento(m_evento mde)
        {
            sql = "delete from tb_evento where id_evento = @codigo";
            try
            {
                con.apagar(mde.codigoevento, sql);
                resultado = true;
            }
            catch
            {
                resultado = false;
            }
            return resultado;
        }
        bool selectok = false;
        int cont = 0;
        ConsultarDados cd = new ConsultarDados();
        //public bool selectEvento (m_evento mse)
        //{
        //    try
        //    {
        //        string sql = "select * from tb_evento set nome_evento where id_evento= @codigo";
        //        string[] campos = { "@nome_evento", "@local_evento", "@data_evento", "@horario_evento", "@descricao_evento" };//falta o id_sala
        //        string[] valores = { mse.Getnome_evento(), mse.Getlocal_evento(), mse.Getdata_evento(), mse.Gethorario_evento(), mse.Getdescricao_evento() };
        //        if (cd.select(mse.codigoevento, campos, valores, sql) >= 1)
        //        {
        //            return resultado = true;
        //        }
        //        else
        //        {
        //            return resultado = false;
        //        }
        //    }
        //    catch (System.Exception ex)
        //    {
        //        throw ex;

        //    }

        //}
            
     }
}

