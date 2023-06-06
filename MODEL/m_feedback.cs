using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class m_feedback
    {
        public int id_feedback;
        public string avaliacao_software;
        public string observacao ;
        public string nome_usuario;
        public m_feedback() 
        {
            id_feedback = 0;
            avaliacao_software = "";
            observacao = "";
            nome_usuario = "";
        }
        public int codigofeedback
        {
            get { return id_feedback; }
            set { id_feedback = value; }
        }

        public string Getavaliacao_software()
        {
            return this.avaliacao_software;
        }
        public string Getobservacao()
        {
            return this.observacao;
        }
        public string Getnome_usuario()
        {
            return this.nome_usuario;
        }
        ////////
        public void setavaliacao_software(string avaliacao_software)
        {
            this.avaliacao_software = avaliacao_software;
        }
        public void setobservavoes (string observacao)
        {
            this.observacao = observacao;
        }
        public void setnome_usuario (string nome_usuario)
        {
            this.nome_usuario = nome_usuario;
        }

    }
}
