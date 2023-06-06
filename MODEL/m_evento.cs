using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class m_evento
    {
        int id_evento;
        string nome_evento;
        string local_evento;
        string data_evento;
        string horario_evento;
        string descricao_evento;
        string dia_da_semana;
        public m_evento()
        {

            id_evento = 0;
            nome_evento = "";
            local_evento = "";
            data_evento = "";
            horario_evento = "";
            descricao_evento = "";
            dia_da_semana = "";


        }
       
        public int codigoevento
        {
            get { return id_evento; }
            set { id_evento = value; }
        }

        public string Getnome_evento()
        {
            return this.nome_evento;
        }
        public string Getlocal_evento()
        {
            return this.local_evento;
        }
        public string Getdata_evento()
        {
            return this.data_evento;
        }
        public string Gethorario_evento()
        {
            return this.horario_evento;
        }
        public string Getdescricao_evento()
        {
            return this.descricao_evento;
        }
        public string Getdia_da_semana()
        {
            return this.dia_da_semana;
        }

        //////////////////////////////
        public void setnome_evento(string nome_evento)
        {
            this.nome_evento = nome_evento;

        }
        public void setlocal_evento(string local_evento)
        {
            this.local_evento = local_evento;

        }
        public void setdata_evento(string data_evento)
        {
            this.data_evento = data_evento;

        }
        public void sethorario_evento(string horario_evento)
        {
            this.horario_evento = horario_evento;

        }
        public void setdescricao_evento(string descricao_evento)
        {
            this.descricao_evento = descricao_evento;

        }
        public void setdia_da_semana(string dia_da_semana)
        {
            this.dia_da_semana = dia_da_semana;

        }
    }
}
