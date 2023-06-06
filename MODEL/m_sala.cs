using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class m_sala
    {
        //"insert into tb_sala_do_predio(nome_sala,descricao_sala,numeracao,bloco) values " + " (@nome_sala,@descricao_sala,@numeracao,@bloco)"
        public int id_sala;
        string nome_sala;
        string descricao_sala;
        string numeracao_sala;
        string bloco_sala;

        public m_sala()
        {

            id_sala = 0;
            numeracao_sala = "";
            bloco_sala = "";
            nome_sala = "";
            descricao_sala = "";


        }
        public int codigosala
        {
            get { return id_sala; }
            set { id_sala = value; }
        }
        
        public string Getnome_sala()
        {
            return this.nome_sala;
        }
        public string Getdescricao_sala()
        {
            return this.descricao_sala;
        }
        public string Getbloco_sala()
        {
            return this.bloco_sala;
        }
        public string Getnumeracao_sala()
        {
            return this.numeracao_sala;
        }
        //////////////////////////////
        public void setnome_sala(string nome_sala)
        {
            this.nome_sala = nome_sala;

        }
        public void setdescricao_sala(string descricao_sala)
        {
            this.descricao_sala = descricao_sala;

        }
        public void setbloco_sala(string bloco_sala)
        {
            this.bloco_sala = bloco_sala;

        }
        public void setnumeracao_sala(string numeracao_sala)
        {
            this.numeracao_sala = numeracao_sala;

        }

      
    }
}
