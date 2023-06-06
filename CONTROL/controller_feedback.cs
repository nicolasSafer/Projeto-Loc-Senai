using MODEL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3;

namespace CONTROL
{
    public class controller_feedback
    {
        bool resultado = false;
        string sql;
        conexao con = new conexao();

        public bool updatesala(m_feedback muf)
        {
            try
            {
                string sql = "UPDATE tb_feedback_software set avaliacao_software = @avaliacao_software, observacao = @observacao, nome_usuario = @nome_usuario where id_feedback=@codigo";
                string[] campos = { "@avaliacao_software", "@observacao", "@nome_usuario" };
                string[] valores = { muf.Getavaliacao_software(), muf.Getobservacao(), muf.Getnome_usuario() };
                if (con.atualizarDados(muf.codigofeedback, campos, valores, sql) >= 1)
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
        public bool ExcluiFeedBack(m_feedback muf)
        {
            sql = "delete from tb_feedback_software where id_feedback = @codigo";
            try
            {
                con.apagar(muf.codigofeedback, sql);
                resultado = true;
            }
            catch
            {
                resultado = false;
            }
            return resultado;
        }
    }
}
